using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using LoginExample.Models;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace FileData
{
    public class FileContext : IFileManager
    {
        private readonly string adultsFile = "adults.json";
        private readonly string childrenFile = "children.json";


        private readonly string familiesFile = "families.json";
        private readonly string petsFile = "pets.json";
        private readonly string usersFile = "users.json";

        public FileContext()
        {
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Children = File.Exists(childrenFile) ? ReadData<Child>(childrenFile) : new List<Child>();
            Pets = File.Exists(petsFile) ? ReadData<Pet>(petsFile) : new List<Pet>();
            Users = File.Exists(usersFile) ? ReadData<User>(usersFile) : new List<User>();
        }

        public IList<Family> Families { get; }
        public IList<Adult> Adults { get; }
        public IList<Child> Children { get; }
        public IList<Pet> Pets { get; }

        public IList<User> Users { get; private set; }
        // public void SaveChanges() {
        //     // storing families
        //     string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions {
        //         WriteIndented = true
        //     });
        //
        //     using (StreamWriter outputFile = new StreamWriter(familiesFile, false)) {
        //         outputFile.Write(jsonFamilies);
        //     }
        //
        //     // storing persons
        //     string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
        //         WriteIndented = true
        //     });
        //
        //     using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
        //         outputFile.Write(jsonAdults);
        //     }
        // }

        public Adult AddAdult(Adult adult)
        {
            Adults.Add(adult);
            SaveAdultsToFile();
            return adult;
        }

        public List<Adult> GetListAdults()
        {
            return (List<Adult>) Adults;
        }

        public Child AddChild(Child child)
        {
            Children.Add(child);
            SaveChildrenToFile();
            return child;
        }

        public List<Child> GetListChildren()
        {
            return (List<Child>) Children;
        }

        public Pet AddPet(Pet addPet)
        {
            Pets.Add(addPet);
            SavePetsToFile();
            return addPet;
        }

        public List<Pet> GetListOfPets()
        {
            return (List<Pet>) Pets;
        }

        public Family AddFamily(Family family)
        {
            Families.Add(family);
            SaveFamilyToFile();
            return family;
        }

        public IList<Family> GetListOfFamilies()
        {
            return (List<Family>) Families;
        }

        public User ValidateUser(User user)
        {
            Users = new[]
            {
                new User
                {
                    UserName = "test",
                    Domain = "via.dk",
                    City = "Horsens",
                    BirthYear = 2000,
                    Role = "Adult",
                    SecurityLevel = 5,
                    Password = "123456"
                },
                new User
                {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1986,
                    SecurityLevel = 5,
                    UserName = "Troels"
                },
                new User
                {
                    City = "Aarhus",
                    Domain = "hotmail.com",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 1998,
                    SecurityLevel = 3,
                    UserName = "Jakob"
                },
                new User
                {
                    City = "Vejle",
                    Domain = "via.com",
                    Password = "123456",
                    Role = "Guest",
                    BirthYear = 1973,
                    SecurityLevel = 1,
                    UserName = "child"
                }
            }.ToList();
            SaveUsersToFile();
            User foundUser = null;
            foreach (var userInFile in Users)
                if (user.UserName == userInFile.UserName && user.Password == userInFile.Password)
                    foundUser = userInFile;

            return foundUser;
        }


        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveAdultsToFile()
        {
            // storing persons
            var jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public void SaveChildrenToFile()
        {
            var jsonAdults = JsonSerializer.Serialize(Children, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(childrenFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public void SavePetsToFile()
        {
            var jsonAdults = JsonSerializer.Serialize(Pets, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(petsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public void SaveFamilyToFile()
        {
            var jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            using (var outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }
        }

        public void SaveUsersToFile()
        {
            var jsonUser = JsonSerializer.Serialize(Users, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (var outputFile = new StreamWriter(usersFile, false))
            {
                outputFile.Write(jsonUser);
            }
        }
    }
}