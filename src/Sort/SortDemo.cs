using Sort.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Linq;
using System.ComponentModel;
using System.Diagnostics; 

namespace Sort
{
    public class SortDemo
    {
        public int[] Scores; 
        public List<SortingAlgo> Algorithms;
        public Stopwatch Timer = new Stopwatch(); 

        public SortDemo()
        {
            Scores = LoadData();

            Algorithms = new List<SortingAlgo>()
            {
                new BubbleSort(),
                new HeapSort(),
                new InsertionSort(),
                new MergeSort(),
                new QuickSort(),
                new SelectionSort()
            };

            foreach (SortingAlgo algo in Algorithms)
            {
                Timer.Start(); 
                algo.Run(Scores);
                Timer.Stop();
                Console.WriteLine($"Runtime: {Timer.Elapsed.ToString()}");
            }

        }


        public int[] LoadData()
        {
            string fileName = "scores.txt";
            string file = $"..\\..\\..\\..\\Sort\\Data\\{fileName}";

            return File.ReadAllLines(file).Select(int.Parse).ToArray();  
        }


        private void About()
        {
            Console.WriteLine("name");
            Console.WriteLine("description");
            Console.WriteLine("notation");
            Console.WriteLine("pseudocode");
            Console.WriteLine("runtime");
        }
    }
}
