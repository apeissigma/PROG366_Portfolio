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
            RunAllSorts(); 
        }

        public void RunAllSorts()
        {
            Algorithms = new List<SortingAlgo>()
            {
                new BubbleSort(),
                new InsertionSort(),
                new SelectionSort(),
                 //new HeapSort(),
                 new QuickSort(),
                new MergeSort()
            };

            foreach (SortingAlgo algo in Algorithms)
            {
                Scores = LoadData(); 
                Timer.Start();
                algo.Run(Scores);
                Timer.Stop();
                Console.WriteLine($"\n > Runtime: {Timer.Elapsed.ToString()}\n");
            }
        }


        public int[] LoadData()
        {
            string fileName = "scores.txt";
            string file = $"..\\..\\..\\..\\Sort\\Data\\{fileName}";

            return File.ReadAllLines(file).Select(int.Parse).ToArray();  
        }
    }
}
