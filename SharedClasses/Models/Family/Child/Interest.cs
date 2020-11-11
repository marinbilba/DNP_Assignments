using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LoginExample.Models.Family.Child
{
    public class Interest
    {
        [Key] [JsonPropertyName("type")] public string Type { get; set; }

        [JsonIgnore] public List<ChildInterest> ChildInterests { get; set; }
    }
}