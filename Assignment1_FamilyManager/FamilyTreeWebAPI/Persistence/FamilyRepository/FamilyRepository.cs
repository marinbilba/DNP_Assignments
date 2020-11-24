using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Microsoft.EntityFrameworkCore;
using Models;

namespace FamilyTreeWebAPI.Persistence.FamilyRepository
{
    public class FamilyRepository : IFamilyRepository
    {
        private FamilyManagerContext ctx;

        public FamilyRepository(FamilyManagerContext ctx)
        {
            this.ctx = ctx;
        }


        public Adult AddAdult(Adult adult)
        {
            ctx.Adults.Add(adult);
            ctx.Entry(adult).State = EntityState.Added;
            ctx.SaveChanges();
            return adult;
        }

        public List<Adult> GetListAdults()
        {
            throw new System.NotImplementedException();
        }

        public Child AddChildFinal(Child child, List<Interest> interestList)
        {
            Child tempChild = AddChild(child);
            foreach (var interest in interestList)
            { 
                Interest tempInterest = interest;
                var fetchedInterest = ctx.Interest.First(i => i.Type.Equals(interest.Type));
                ChildInterest childInterest = new ChildInterest()
                {
                    Child = tempChild,
                    ChildId = tempChild.Id,
                    Interest = fetchedInterest,
                    InterestId = fetchedInterest.Type
                };
                tempChild.ChildInterests=new List<ChildInterest>();
                tempChild.ChildInterests.Add(childInterest);
            }
            ctx.Update(tempChild);
            ctx.SaveChangesAsync();
            return tempChild;
        }

        private Child AddChild(Child child)
        {
            Child tempChild = new Child()
            {
                Id = child.Id,
                IsPartOfFamily = child.IsPartOfFamily,
                FirstName = child.FirstName,
                LastName = child.LastName,
                HairColor = child.HairColor,
                EyeColor = child.EyeColor,
                Age = child.Age,
                Weight = child.Weight,
                Height = child.Height,
                Sex = child.Sex,
                ChildInterests = child.ChildInterests
            };
            ctx.Child.Add(tempChild);
            ctx.Entry(tempChild).State = EntityState.Added;
            ctx.SaveChanges();
            return tempChild;
        }

        /**
 * Iterate through the existing interest and if one is not found from the
 * parameter list of interest it should be added to the database
 */
        public List<Interest> AddNewInterest(List<ChildInterest> childInterests)
        {
            List<Interest> tempInterestList = new List<Interest>();
            foreach (var interestArray in childInterests)
            {
                var interest = interestArray.Interest;
                // if interest is not found, it should be added 
                if ( ctx.Interest.Find(interest.Type) == null)
                {
                    ctx.Interest.Add(interest);
                    ctx.Entry(interest).State = EntityState.Added;
                    ctx.SaveChanges();
                    tempInterestList.Add(interest);
                }
            }

            return tempInterestList;
        }

        public List<Child> GetListChildren()
        {
            return ctx.Child.ToList();
        }

        public Pet AddPet(Pet addPet)
        {
            ctx.Pet.Add(addPet);
            ctx.Entry(addPet).State = EntityState.Added;
            ctx.SaveChanges();
            return addPet;
        }

        public List<Pet> GetListOfPets()
        {
            return ctx.Pet.ToList();
        }

        public Family AddFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public IList<Family> GetListOfFamilies()
        {
            throw new System.NotImplementedException();
        }
    }
}