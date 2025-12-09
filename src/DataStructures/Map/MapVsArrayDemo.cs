using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructures.Map
{
    public class MapVsArrayDemo
    {
        public MapVsArrayDemo()
        {
            Console.WriteLine("\n=============== Maps Vs Arrays ===============");

            Console.WriteLine("\n---------- Map Implementation ----------");
            Console.WriteLine("Maps are abstract data structures that implement an associative array which maps keys to values.");
            Console.WriteLine(" > More specifically, hashmaps involve a hashing function that generates unique keys to index elements.");
            Console.WriteLine(" > Maps are non-sequential, and do not store elements in a particular order.");
            Console.WriteLine("Choose a map over an array when...");
            Console.WriteLine(" > Needing to access an element by it's key rather than it's index");
            Console.WriteLine(" > Storing irregular or non-sequential data");
            Console.WriteLine("C# has two built in map types, both with the same functionality:");
            Console.WriteLine(" > Hashtable: a non-generic collection of key/value pairs that returns object types.");
            Console.WriteLine(" > Dictionary: a generic collection of key/value pairs with better performance than hashtables.");
            MapDemo();

            Console.WriteLine("\n---------- Array Implementation ----------");
            Console.WriteLine("Arrays are linear, concrete data structures that store a sequence of elements of the same type.");
            Console.WriteLine(" > Elements are indexed, and array indexes are 0-based.");
            Console.WriteLine(" > Arrays are fixed size, and must be resized in order to add more elements.");
            Console.WriteLine("Choose an array over a map when...");
            Console.WriteLine(" > Associated values aren't necessary");
            Console.WriteLine(" > Storing ordered, index-based data");
            Console.WriteLine(" > Needing to prioritize memory efficiency");
            ArrayDemo(); 
        }

        public void MapDemo()
        {
            Console.WriteLine("\n~~~~~ Hashtable Demo ~~~~~");
            Hashtable htable = new Hashtable();

            Console.WriteLine("Adding [1, 'This'], [2, 'Is'], [3, 'A'], [4, 'Hashtable']");
            htable.Add(1, "This");
            htable.Add(2, "Is");
            htable.Add(3, "A");
            htable.Add(4, "Hashtable");

            Console.Write($"\nFind the last value via it's key (4): {htable[4]}");

            Console.Write("\nReassign the last value via it's key (4): ");
            htable[4] = "Hash-what?";
            Console.WriteLine(htable[4]);

            Console.WriteLine("\nLoop through each key/value pair:");
            foreach (DictionaryEntry kv in htable) Console.WriteLine($" > {kv.Key} {kv.Value}");




            Console.WriteLine("\n~~~~~ Dictionary Demo ~~~~~");
            Dictionary<int, string> dict = new Dictionary<int, string>();

            Console.WriteLine("Adding [1, 'This'], [2, 'Is'], [3, 'A'], [4, 'Dictionary']");
            dict.Add(1, "This");
            dict.Add(2, "Is");
            dict.Add(3, "A");
            dict.Add(4, "Dictionary");

            Console.Write($"\nFind the last value via it's key (4): {dict[4]}");

            Console.Write("\nReassign the last value via it's key (4): ");
            dict[4] = "Dictiona-what?";
            Console.WriteLine(dict[4]);

            Console.WriteLine("\nLoop through each key/value pair:");
            foreach (KeyValuePair<int, string> kv in dict) Console.WriteLine($" > {kv.Key} {kv.Value}");
        }

        public void ArrayDemo()
        {
            Console.WriteLine("\n~~~~~ Array Demo ~~~~~");

            Console.WriteLine("Creating an array of 4 values: 'This', 'Is', 'An', 'Array'");
            string[] arr = new string[4] { "This", "Is", "An", "Array" };

            Console.Write($"\nFind the last value via it's index (3): {arr[3]}");

            Console.Write("\nReassign the last value via it's index (3): ");
            arr[3] = "Arr-what?";
            Console.WriteLine(arr[3]);

            Console.WriteLine("\nLoop through each index and value:");
            for (int i = 0; i < arr.Length; i++) Console.WriteLine($" > {i} {arr[i]}");
        }
    }
}
