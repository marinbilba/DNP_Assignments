using System.ComponentModel.DataAnnotations;

namespace LoginExample.Models.Family.Child.Pet {
public class Pet {
    public int Id { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Age { get; set; }

    public bool IsPartOfFamily { get; set; }

    
    public override string ToString()
    {
        return ($"Name: {Name} Species: {Species} Age: {Age}");
    }
}
}