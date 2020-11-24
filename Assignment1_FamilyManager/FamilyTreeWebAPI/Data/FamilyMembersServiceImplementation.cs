using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyTreeWebAPI.Persistence;
using FamilyTreeWebAPI.Persistence.FamilyRepository;
using FamilyTreeWebAPI.Persistence.User;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;
using SharedClasses.Models;

namespace LoginExample.Data
{
    public class FamilyMembersServiceImplementation : IFamilyMembersService
    {
        private readonly FamilyManagerContext familyManagerContext=new FamilyManagerContext();
        private readonly IFamilyRepository familyRepository;
        private readonly IUserRepository userRepository;

        public FamilyMembersServiceImplementation()
        {
            familyRepository = new FamilyRepository(familyManagerContext);
            userRepository = new UserRepository(familyManagerContext);
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            return familyRepository.AddAdult(adult);
        }

        public async Task<IList<Adult>> GetListOfAdultsAsync()
        {
            return familyRepository.GetListAdults();
        }

        public async Task<Child> AddChild(Child child)
        {
            // Add new interest to the db
            List<Interest> interestList = familyRepository.AddNewInterest(child.ChildInterests);
            return familyRepository.AddChildFinal(child,interestList);
        }

        public async Task<IList<Child>> GetListOfChildren()
        {
            return familyRepository.GetListChildren();
        }

        public async Task<Pet> AddPet(Pet addPet)
        {
            return familyRepository.AddPet(addPet);
        }

        public async Task<IList<Pet>> GetListOfPets()
        {
            return familyRepository.GetListOfPets();
        }

        public async Task<Family> AddFamily(Family family)
        {
            return familyRepository.AddFamily(family);
        }

        public async Task<IList<Family>> GetListOfFamilies()
        {
            return familyRepository.GetListOfFamilies();
        }

        public User ValidateUser(User user)
        {
            User tempUser = null;
            tempUser= userRepository.GetUser(user);
            if (tempUser == null)
            {
                throw new Exception("Username or password is incorrect");
            }

            return tempUser;
        }
    }
}