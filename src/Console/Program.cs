using BigO;
using Shuffle;
using DataStructures;
using DataStructures.Map; 

namespace PROG366_Portfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forcast forcast = new Forcast();
            //forcast.Go(); 

            MapDemo mapDemo = new MapDemo();
            Console.WriteLine("\n===== Linear Hashmap Implementation =====");
            mapDemo.LinHashDemo();
            Console.WriteLine("\n===== Chaining Hashmap Implementation =====");
            mapDemo.ChainHashDemo(); 
        }
    }
}