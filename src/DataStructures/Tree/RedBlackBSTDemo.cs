using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructures.Tree
{
    public class RedBlackBSTDemo
    {
        string filePath = $"..\\..\\..\\..\\DataStructures\\Tree\\Data\\scores.txt";

        public RedBlackBSTDemo()
        {
            Console.WriteLine("\n========================= Red Black Tree Implementation =========================");
            Console.WriteLine("*** See README.md for data structure information and comparisons ***\n");
            Demo();
            
        }

        private void Demo()
        {
            RedBlackBST tree = new RedBlackBST();
            int[] data = GetData();

            Console.WriteLine("Inserting data into tree...\n");
            foreach (var num in data) 
            {
                tree.Insert(num, num);
            }

            Console.WriteLine($"Amount of data added: {data.Length} numbers");
            Console.WriteLine($"Total count of nodes in tree: {tree.Count}");
            Console.WriteLine($"Root: {tree.Root.Key}");
            Console.WriteLine($"Height of tree: {tree.Height()}\n");

            Console.WriteLine("Testing get function...");
            for (int i = 0; i < 5; i++)
            {
                int testKey = data[i];
                int? result = tree.Get(testKey);
                Console.WriteLine($" > Search key: {testKey}, Result: {result} {(result == testKey)}");
            }        
        }

        private int[] GetData()
        {
            string[] lines = File.ReadAllLines(filePath);
            int[] data = new int[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = Int32.Parse(lines[i]);
            }
            return data;
        }
    }
}
