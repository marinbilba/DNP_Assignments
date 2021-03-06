using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LoginExample.Models.Family.Child.Pet
{
    public class Pet
    {
        [Key]
        [JsonPropertyName("id")] public int Id { get; set; }

        [Required]
        [JsonPropertyName("species")]
        public string Species { get; set; }

        [Required] [JsonPropertyName("name")] public string Name { get; set; }

        [Required] [JsonPropertyName("age")] public int Age { get; set; }

        public bool IsPartOfFamily { get; set; }


        public override string ToString()
        {
            return $"Name: {Name} Species: {Species} Age: {Age}";
        }
    }
}