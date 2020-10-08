using System.Collections.Generic;
using FileData;
using LoginExample.Data.AddFamilyMembersService;
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

        public void AddChild(Child adult)
        {
            throw new System.NotImplementedException();
        }

        public List<Child> GetListOfChildren()
        {
            throw new System.NotImplementedException();
        }
    }
}