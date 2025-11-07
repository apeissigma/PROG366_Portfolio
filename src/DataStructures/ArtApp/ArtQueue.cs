using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataStructures.ArtApp
{
    public class ArtQueue
    {
        public Queue<ArtObject> objQueue;

        public ArtQueue()
        {
            objQueue = LoadData();
            About(objQueue);
        }

        private Queue<ArtObject> LoadData()
        {
            string fileName = "metObjects.json";
            string jsonData = File.ReadAllText($"..\\..\\..\\..\\DataStructures\\Data\\{fileName}");

            return JsonSerializer.Deserialize<Queue<ArtObject>>(jsonData);
        }
        private void DisplayAll(Queue<ArtObject> queue)
        {
            int i = 0;
            foreach (ArtObject obj in queue)
            {
                Console.WriteLine($"{i}: {DisplayObj(obj)}\n");
                i++;
            }
        }

        private string DisplayObj(ArtObject obj)
        {
            return $"{obj.Title}, {obj.Date}\n+ Artist: {obj.Artist}";
        }

        private void About(Queue<ArtObject> queue)
        {
            var first = queue.Peek();

            Console.WriteLine("ArtQueue");
            Console.WriteLine("Count " + queue.Count);
            Console.WriteLine("First " + DisplayObj(first));
        }
    }
}
