using DataStructures.StackQueue;
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
        string filePath = $"..\\..\\..\\..\\DataStructures\\Data\\DataStructuresData.txt";

        public MapVsArrayDemo()
        {
            Console.WriteLine("\n========================= Maps Vs Arrays =========================");
            Console.WriteLine("*** See README.md for data structure information and comparisons ***");

            Console.WriteLine("\n---------- Map Implementation ----------");
            HashtableDemo();
            DictionaryDemo(); 

            Console.WriteLine("\n---------- Array Implementation ----------");
            ArrayDemo(); 
        }

        private void HashtableDemo()
        {
            Console.WriteLine("\n~~~~~ Hashtable Demo ~~~~~");
            Hashtable htable = new Hashtable();

            Console.WriteLine("Adding Data (values 1-501)");
            var data = File.ReadAllLines(filePath);
            int i = 1;
            foreach (var line in data)
            {
                htable.Add(i, Int32.Parse(line));
                i++;
            }

            Console.Write($"\nFind the first value via it's key (1): {htable[1]}");
            Console.Write($"\nFind the last value via it's key (500): {htable[500]}");

            Console.Write("\nReassign the last value via it's key (500): ");
            htable[500] = "Hey!";
            Console.WriteLine(htable[500]);

            Console.WriteLine("\nLoop through the first 5 key/value pairs:"); //demonstrates how values are retrieved
            int j = 0;
            foreach (DictionaryEntry kv in htable)
            {
                if (j == 5) break;
                Console.WriteLine($" > [ {kv.Key}, {kv.Value} ]");
                j++;
            }
        }

        private void DictionaryDemo()
        {
            Console.WriteLine("\n~~~~~ Dictionary Demo ~~~~~");
            Dictionary<int, string> dict = new Dictionary<int, string>();

            Console.WriteLine("Adding Data (values 1-501)");
            var data = File.ReadAllLines(filePath);
            int i = 1;
            foreach (var line in data)
            {
                dict.Add(i, line);
                i++;
            }

            Console.Write($"\nFind the first value via it's key (1): {dict[1]}");
            Console.Write($"\nFind the last value via it's key (500): {dict[500]}");

            Console.Write("\nReassign the first value via it's key (1): ");
            dict[1] = "Hey!";
            Console.WriteLine(dict[1]);

            Console.WriteLine("\nLoop through the first 5 key/value pairs:"); //demonstrates how values are retrieved
            int j = 0;
            foreach (KeyValuePair<int, string> kv in dict)
            {
                if (j == 5) break;
                Console.WriteLine($" > [ {kv.Key}, {kv.Value} ]");
                j++;
            }
        }

        private void ArrayDemo()
        {
            Console.WriteLine("Initializing Array with Data (values 1-501)");
            int[] arr = File.ReadAllLines(filePath).Select(int.Parse).ToArray();

            int firstIndex = 0;
            int lastIndex = arr.Length - 1; 

            Console.Write($"\nFind the first value via it's index (0): {arr[firstIndex]}");
            Console.Write($"\nFind the last value via it's index (500): {arr[lastIndex]}");

            Console.Write("\nReassign the last value via it's index (500): ");
            arr[lastIndex] = 1000;
            Console.WriteLine(arr[lastIndex]);
        }
    }
}
