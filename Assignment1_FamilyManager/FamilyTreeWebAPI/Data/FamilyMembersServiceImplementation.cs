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
        private readonly IFileManager _fileManager;

        public AddFamilyMembersServiceImplementation()
        {
            _fileManager = new FileContext();
        }

        public async Task<Adult> AddAdultAsync(Adult adult)
        {
            return _fileManager.AddAdult(adult);
        }

        public async Task<IList<Adult>> GetListOfAdultsAsync()
        {
            return _fileManager.GetListAdults();
        }

        public async Task<Child> AddChild(Child child)
        {
            return _fileManager.AddChild(child);
        }

        public async Task<IList<Child>> GetListOfChildren()
        {
            return _fileManager.GetListChildren();
        }

        public async Task<Pet> AddPet(Pet addPet)
        {
            return _fileManager.AddPet(addPet);
        }

        public async Task<IList<Pet>> GetListOfPets()
        {
            return _fileManager.GetListOfPets();
        }

        public async Task<Family> AddFamily(Family family)
        {
            return _fileManager.AddFamily(family);
        }

        public async Task<IList<Family>> GetListOfFamilies()
        {
            return _fileManager.GetListOfFamilies();
        }

        public User ValidateUser(User user)
        {
            return _fileManager.ValidateUser(user);
        }
    }
}