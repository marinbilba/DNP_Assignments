using System.Collections.Generic;
using System.Threading.Tasks;
using FileData;
using LoginExample.Data.AddFamilyMembersService;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace LoginExample.Data
{
    public class AddFamilyMembersServiceImplementation : IAddFamilyMembersService
    {
        private IFileManager _fileManager;

        public AddFamilyMembersServiceImplementation()
        {
            _fileManager=new FileContext();
            
        }

        public async Task AddAdultAsync(Adult adult)
        {
            _fileManager.AddAdult(adult);
        }

        public async Task<IList<Adult>> GetListOfAdultsAsync()
        {
      return _fileManager.GetListAdults();
  
        }

        public async Task AddChild(Child child)
        {
           _fileManager.AddChild(child);
        }

        public async Task<IList<Child>> GetListOfChildren()
        {
            return _fileManager.GetListChildren();
        }

        public async Task AddPet(Pet addPet)
        {
            _fileManager.AddPet(addPet);
        }

        public async Task<IList<Pet>> GetListOfPets()
        {
            return _fileManager.GetListOfPets();
        }

        public async Task AddFamily(Family family)
        {
            _fileManager.AddFamily(family);
        }

        public async Task<IList<Family>> GetListOfFamilies()
        {
          return _fileManager.GetListOfFamilies();
        }
    }
}