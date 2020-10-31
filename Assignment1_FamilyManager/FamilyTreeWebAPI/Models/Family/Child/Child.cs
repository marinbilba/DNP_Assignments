using System.Collections.Generic;
using System.Text.Json.Serialization;
using Models;

namespace LoginExample.Models.Family.Child {
public class Child : Person {
    [JsonPropertyName("childInterests")]
    public List<ChildInterest> ChildInterests { get; set; }
    [JsonPropertyName("pets")]
    public List<Pet.Pet> Pets { get; set; }
    public bool IsPartOfFamily { get; set; }

    
    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

}
}