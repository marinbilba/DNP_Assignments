using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;

namespace Models
{
    public class Family
    {
        public Family()
        {
            Adults = new List<Adult>();
        }

        //public int Id { get; set; }
      
        [Required]
        [JsonPropertyName("familyName")]
        public string FamilyName { get; set; }

        [Required]
        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [Required]
        [JsonPropertyName("houseNumber")]
        public int HouseNumber { get; set; }

        [JsonPropertyName("adults")] public List<Adult> Adults { get; set; }

        [JsonPropertyName("children")] public List<Child> Children { get; set; }

        [JsonPropertyName("pets")] public List<Pet> Pets { get; set; }
    }
}