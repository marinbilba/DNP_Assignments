using System.Collections.Generic;
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

        public Child AddChild(Child child)
        {
            throw new System.NotImplementedException();
        }

        public List<Child> GetListChildren()
        {
            throw new System.NotImplementedException();
        }

        public Pet AddPet(Pet addPet)
        {
            throw new System.NotImplementedException();
        }

        public List<Pet> GetListOfPets()
        {
            throw new System.NotImplementedException();
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