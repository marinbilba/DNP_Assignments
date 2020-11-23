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
    public class AddFamilyMembersServiceImplementation : IAddFamilyMembersService,IUserRepository
    {
        private readonly FamilyManagerContext familyManagerContext;
        private readonly IFamilyRepository familyRepository;
        private readonly IUserRepository userRepository;

        public AddFamilyMembersServiceImplementation()
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
            return familyRepository.AddChild(child);
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
            return userRepository.ValidateUser(user);
        }
    }
}