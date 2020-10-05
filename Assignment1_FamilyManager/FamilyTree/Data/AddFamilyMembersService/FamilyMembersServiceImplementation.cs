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
            List<Adult> temp = _fileManager.ReadAdultFile();
            return temp;
        }
    }
}