using System.Collections.Generic;
using System.Threading.Tasks;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace LoginExample.Data.AddFamilyMembersService
{
    public interface IAddFamilyMembersService
    {
        // Functionality used for AddAdultAsync & AdultsOverview blazor pages
        Task AddAdultAsync(Adult adult);
        Task<IList<Adult>> GetListOfAdultsAsync();
        
        // Functionality used for AddChild && ChildrenOverview  blazor pages
        
        Task AddChild(Child child);
        Task<IList<Child>> GetListOfChildren();
        
        // Functionality used for AddPets && PetsOverview  blazor pages
        Task AddPet(Pet addPet);
        // Functionality used for AddFamily && FamiliesOverview  blazor pages
        Task<IList<Pet>> GetListOfPets();
        Task AddFamily(Family family);

        Task<IList<Family>> GetListOfFamilies();
        
        User ValidateUser(string userName, string password);
    }
}