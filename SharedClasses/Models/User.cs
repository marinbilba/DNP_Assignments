using System.Text.Json.Serialization;

namespace LoginExample.Models
{
    public class User
    {
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(string userName, string domain, string city, int birthYear, string role, int securityLevel,
            string password)
        {
            UserName = userName;
            Domain = domain;
            City = city;
            BirthYear = birthYear;
            Role = role;
            SecurityLevel = securityLevel;
            Password = password;
        }

        public User()
        {
        }

        [JsonPropertyName("userName")] public string UserName { get; set; }

        [JsonPropertyName("domain")] public string Domain { get; set; }

        [JsonPropertyName("city")] public string City { get; set; }

        [JsonPropertyName("birthYear")] public int BirthYear { get; set; }

        [JsonPropertyName("role")] public string Role { get; set; }

        [JsonPropertyName("securityLevel")] public int SecurityLevel { get; set; }

        [JsonPropertyName("password")] public string Password { get; set; }
    }
}