using System.Collections.Generic;
using FileData;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace FamilyTreeWebAPI.Persistence
{
    public class FamilyRepository : IFamilyRepository
    {
        private FamilyMembersContext ctx;

        public FamilyRepository(FamilyMembersContext ctx)
        {
            this.ctx = ctx;
        }

        
        
        public Adult AddAdult(Adult adult)
        {
            throw new System.NotImplementedException();
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

        public User ValidateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}