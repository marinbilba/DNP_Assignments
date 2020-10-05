using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Models;

namespace FileData {
public class FileContext : IFileManager {
    public IList<Family> Families { get; private set; }
    public IList<Adult> Adults { get; private set; }

    private readonly string familiesFile = "families.json";
    private readonly string adultsFile = "adults.json";

    public FileContext() {
        Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
    }
    
// What is doing???
    private IList<T> ReadData<T>(string s) {
        using (var jsonReader = File.OpenText(s)) {
            return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
        }
    }
    
    public void SaveChanges() {
        // storing families
        string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(familiesFile, false)) {
            outputFile.Write(jsonFamilies);
        }

        // storing persons
        string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
            outputFile.Write(jsonAdults);
        }
    }
    public void AddAdult(Adult adult)
    {
        List<Adult> temp=new List<Adult>();
        temp.Add(adult);
        string jsonAdults = JsonSerializer.Serialize(temp, new JsonSerializerOptions {
            WriteIndented = true
        });

        using (StreamWriter outputFile = new StreamWriter(adultsFile, true))
        {
            outputFile.Write(jsonAdults);
        }
    }
    public List<Adult> ReadAdultFile()
    {  
                
        List<Adult> temp;
        var stringBuilder = new StringBuilder();
        using (var streamReader = new StreamReader(adultsFile))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null) stringBuilder.Append(line);

            temp = JsonSerializer.Deserialize<List<Adult>>(stringBuilder.ToString());
        }

        Console.WriteLine(temp.ToArray().ToString());
        return temp;
    }

    
}
}