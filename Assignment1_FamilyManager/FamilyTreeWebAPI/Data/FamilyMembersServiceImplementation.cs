using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace LoginExample.Data
{
    public class AddFamilyMembersServiceImplementation : IAddFamilyMembersService
    {
        private readonly IFamilyRepository familyRepository;

        public AddFamilyMembersServiceImplementation()
        {
            familyRepository = new FileContext();
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
            return familyRepository.ValidateUser(user);
        }
    }
}