using System.Text.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class Adult : Person
    {
        public Adult()
        {
            IsPartOfFamily = false;
        }

        [JsonPropertyName("jobTitle")] public string JobTitle { get; set; }

        public bool IsPartOfFamily { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        public void Update(Adult toUpdate)
        {
            JobTitle = toUpdate.JobTitle;
            base.Update(toUpdate);
        }
    }
}