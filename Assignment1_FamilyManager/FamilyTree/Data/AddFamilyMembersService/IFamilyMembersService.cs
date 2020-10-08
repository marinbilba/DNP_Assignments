using System.Collections.Generic;
using Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public interface IAddFamilyMembersService
    {
        // Functionality used for AddAdult & AdultsOverview blazor pages
        void AddAdult(Adult adult);
        List<Adult> GetListOfAdults();
        
        // Functionality used for AddChild && ChildrenOverview  blazor pages
        
        void AddChild(Child adult);
        List<Child> GetListOfChildren();
    }
}