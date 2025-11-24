using Search.Algorithms;
using System.Diagnostics;
using Sort.Algorithms; 

namespace Search;

public class SearchDemo
{
    public int[] Scores;
    public List<SearchingAlgo> Algorithms;
    public Stopwatch Timer;
    public int target = 22;

    public SearchDemo() 
    {
        RunAllSearches();
    }

    public void RunAllSearches()
    {
        Algorithms = new List<SearchingAlgo>()
        {
            new LinearSearch(),
            new BinarySearch(),
            new InterpolationSearch()
        };

        foreach (SearchingAlgo algo in Algorithms)
        {
            Timer = new Stopwatch();
            Scores = LoadData();

            //sort before Binary and Interpolation searches
            //do not include in runtime count
            if (algo.Name == "Binary Search" || algo.Name == "Interpolation Search")
                Array.Sort(Scores);

            Timer.Start();
            algo.Run(Scores, target);
            Timer.Stop();
            if (algo.Name == "Binary Search" || algo.Name == "Interpolation Search")
                Console.WriteLine("\n > Dataset sorted");

            Console.WriteLine($"\n > Runtime: {Timer.Elapsed.ToString()}\n");
        }
    }


    public int[] LoadData()
    {
        string fileName = "scores.txt";
        string file = $"..\\..\\..\\..\\Search\\Data\\{fileName}";

        return File.ReadAllLines(file).Select(int.Parse).ToArray();
    }
}
