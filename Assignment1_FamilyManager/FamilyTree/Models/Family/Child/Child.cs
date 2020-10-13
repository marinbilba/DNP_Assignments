using System.Collections.Generic;
using Models;

namespace LoginExample.Models.Family.Child {
public class Child : Person {
    
    public List<ChildInterest> ChildInterests { get; set; }
    public List<Pet.Pet> Pets { get; set; }
    public bool IsPartOfFamily { get; set; }

    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

}
}