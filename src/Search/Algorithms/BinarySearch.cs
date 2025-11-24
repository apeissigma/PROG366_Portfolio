using Search.Algorithms;
using System.Security.Cryptography;
using Sort.Algorithms;

namespace Search.Algorithms;

public class BinarySearch : SearchingAlgo
{
    public override string Name { get => "Binary Search"; }

    public override void Run(int[] arr, int target)
    {
        Display();
        Console.WriteLine($"Target: {target}");
        var tIndex = Search(arr, 0, arr.Length - 1, target);
        Console.WriteLine($"Target {arr[tIndex]} found at index {tIndex}");
    }

    public int Search(int[] arr, int low, int high, int target)
    {
        //continue recursion as long as lower bound is less than higher bound
        if (low <= high) 
        {
            //calculate mid index
            int mid = (high + low) / 2;

            //if mid point matches target, return
            if (arr[mid] == target) return mid;

            //if target is larger than midpoint, 
            //set new lower bound and search again
            if (arr[mid] < target) return Search(arr, mid + 1, high, target);

            //if target is less than the midpoint
            //set new upper bound and search again
            else return Search(arr, low, mid - 1, target);
        }
        //if not found
        return -1;
    }
}
