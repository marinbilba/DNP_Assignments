using System.Collections.Generic;
using Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public interface IAddFamilyMembersService
    {
        void AddAdult(Adult adult);
        List<Adult> GetListOfAdults();
    }
}