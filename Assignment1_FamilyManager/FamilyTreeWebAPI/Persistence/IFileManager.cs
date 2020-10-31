using System.Collections.Generic;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace FileData
{
    public interface IFileManager
    {
        Adult AddAdult(Adult adult);
        List<Adult> GetListAdults();
        
        void AddChild(Child child);
        List<Child> GetListChildren();


        void AddPet(Pet addPet); 
        List<Pet> GetListOfPets();

        void AddFamily(Family family);
        IList<Family> GetListOfFamilies();
        
    }
    
}