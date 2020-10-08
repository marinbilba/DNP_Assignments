using System.Collections.Generic;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public interface IAddFamilyMembersService
    {
        // Functionality used for AddAdult & AdultsOverview blazor pages
        void AddAdult(Adult adult);
        List<Adult> GetListOfAdults();
        
        // Functionality used for AddChild && ChildrenOverview  blazor pages
        
        void AddChild(Child child);
        List<Child> GetListOfChildren();
        void AddPet(Pet addPet);
        List<Pet> GetListOfPets();
    }
}