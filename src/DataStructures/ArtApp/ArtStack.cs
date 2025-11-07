using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataStructures.ArtApp
{
    public class ArtStack
    {
        public Stack<ArtObject> objStack; 

        public ArtStack() 
        {
            objStack = LoadData();
            About(objStack);
        }

        private Stack<ArtObject> LoadData()
        {
            string fileName = "metObjects.json";
            string jsonData = File.ReadAllText($"..\\..\\..\\..\\DataStructures\\Data\\{fileName}");

            return JsonSerializer.Deserialize<Stack<ArtObject>>(jsonData);
        }


        private void DisplayAll(Stack<ArtObject> stack)
        {
            int i = 0;
            foreach (ArtObject obj in stack)
            {
                Console.WriteLine($"{i}: {DisplayObj(obj)}\n");
                i++;
            }
        }

        private string DisplayObj(ArtObject obj)
        {
            return $"{obj.Title}, {obj.Date}\n+ Artist: {obj.Artist}";
        }

        private void About(Stack<ArtObject> stack)
        {
            var first = stack.Peek(); 

            Console.WriteLine("ArtStack");
            Console.WriteLine("Count " + stack.Count);
            Console.WriteLine("First " + DisplayObj(first));
        }
    }
}
