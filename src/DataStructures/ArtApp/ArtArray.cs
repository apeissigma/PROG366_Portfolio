using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DataStructures;
using DataStructures.ArtApp; 

namespace DataStructures.ArtApp; 

public class ArtArray
{
    public ArtObject[] objArr;

    public ArtArray()
    {
        objArr = LoadData();
        Display(objArr);
    }

    private ArtObject[] LoadData()
    {
        string fileName = "metObjects.json";
        string jsonData = File.ReadAllText($"..\\..\\..\\..\\DataStructures\\Data\\{fileName}");

        return JsonSerializer.Deserialize<ArtObject[]>(jsonData);
    }

    private void Display(ArtObject[] arr)
    {
        int i = 0;
        foreach (ArtObject obj in arr)
        {
            Console.WriteLine(i + obj.Title + obj.Artist + obj.Date);
            i++;
        }
    }
}
