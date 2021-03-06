﻿using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;
using SharedClasses.Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public interface IFamilyMembersService
    {
        // Functionality used for AddAdultAsync & AdultsOverview blazor pages
        Task<Adult> AddAdultAsync(Adult adult);
        Task<IList<Adult>> GetListOfAdultsAsync();

        // Functionality used for AddChildFinal && ChildrenOverview  blazor pages

        Task<Child> AddChild(Child child);
        Task<IList<Child>> GetListOfChildren();

        // Functionality used for AddPets && PetsOverview  blazor pages
        Task<Pet> AddPet(Pet addPet);

        // Functionality used for AddFamily && FamiliesOverview  blazor pages
        Task<IList<Pet>> GetListOfPets();
        Task<Family> AddFamily(Family family);

        Task<IList<Family>> GetListOfFamilies();

        User ValidateUser(User user);
    }
}