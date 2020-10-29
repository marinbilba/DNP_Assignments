using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using LoginExample.Models.Family.Child;
using LoginExample.Models.Family.Child.Pet;
using Models;

namespace FileData {
public class FileContext : IFileManager {
    public IList<Family> Families { get; private set; }
    public IList<Adult> Adults { get; private set; }
    public IList<Child> Children { get; private set; }
    public IList<Pet> Pets { get; private set; }

    private readonly string familiesFile = "families.json";
    private readonly string adultsFile = "adults.json";
    private readonly string childrenFile = "children.json";
    private readonly string petsFile = "pets.json";

    public FileContext() {
        
        Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        Children = File.Exists(childrenFile) ? ReadData<Child>(childrenFile) : new List<Child>();
        Pets = File.Exists(petsFile) ? ReadData<Pet>(petsFile) : new List<Pet>();
    }
    
    

    private IList<T> ReadData<T>(string s) {
        using (var jsonReader = File.OpenText(s)) {
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }
    }

    public void SaveAdultsToFile()
    {
        // storing persons
        string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
    public void SaveChildrenToFile()
    {
     
        string jsonAdults = JsonSerializer.Serialize(Children, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(childrenFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
    public void SavePetsToFile()
    {
     
        string jsonAdults = JsonSerializer.Serialize(Pets, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(petsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
    public void SaveFamilyToFile()
    {
        string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(familiesFile, false)) {
            outputFile.Write(jsonFamilies);
        }
    }
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
    
    public void AddAdult(Adult adult)
    {
     Adults.Add(adult);
    SaveAdultsToFile();
    }

    public List<Adult> GetListAdults()
    {
        return (List<Adult>) Adults;
    }

    public void AddChild(Child child)
    {
    Children.Add(child);
    SaveChildrenToFile();
    }

    public List<Child> GetListChildren()
    {
        return (List<Child>) Children;
    }

    public void AddPet(Pet addPet)
    {
        Pets.Add(addPet);
        SavePetsToFile();
    }

    public List<Pet> GetListOfPets()
    {
        return (List<Pet>) Pets;
    }

    public void AddFamily(Family family)
    {
        Families.Add(family);
        SaveFamilyToFile();
    }

    public IList<Family> GetListOfFamilies()
    {
        return (List<Family>) Families;
    }
}
}