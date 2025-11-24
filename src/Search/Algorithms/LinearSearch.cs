namespace Search.Algorithms;

public class LinearSearch : SearchingAlgo
{
    public override string Name { get => "Linear Search"; }

    public override void Run(int[] arr, int target)
    {
        Display(); 
        Console.WriteLine($"Target: {target}");
        var tIndex = Search(arr, target); 
        Console.WriteLine($"Target {arr[tIndex]} found at index {tIndex}");
    }

    public int Search(int[] arr, int target)
    {
        //iterate through each value in arr until target is found
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == target) return i;
        }
        //if not found
        return -1;
    }
}
