using System.Collections.Generic;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace FileData
{
    public interface IFileManager
    {
        Adult AddAdult(Adult adult);
        List<Adult> GetListAdults();
        
        Child AddChild(Child child);
        List<Child> GetListChildren();


        Pet AddPet(Pet addPet); 
        List<Pet> GetListOfPets();

        Family AddFamily(Family family);
        IList<Family> GetListOfFamilies();

        User ValidateUser(User user);
    }
    
}