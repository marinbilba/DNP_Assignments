using System.Collections.Generic;
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

        public void AddAdult(Adult adult)
        {
            _fileManager.AddAdult(adult);
        }

        public List<Adult> GetListOfAdults()
        {
      return _fileManager.GetListAdults();
  
        }

        public void AddChild(Child child)
        {
           _fileManager.AddChild(child);
        }

        public List<Child> GetListOfChildren()
        {
            return _fileManager.GetListChildren();
        }

        public void AddPet(Pet addPet)
        {
            _fileManager.AddPet(addPet);
        }

        public List<Pet> GetListOfPets()
        {
            return _fileManager.GetListOfPets();
        }

        public void AddFamily(Family family)
        {
            _fileManager.AddFamily(family);
        }
    }
}