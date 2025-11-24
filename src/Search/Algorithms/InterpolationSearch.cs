namespace Search.Algorithms;

public class InterpolationSearch : SearchingAlgo
{
    public override string Name { get => "Interpolation Search"; }

    public override void Run(int[] arr, int target)
    {
        Display();
        Console.WriteLine($"Target: {target}");
        var tIndex = Search(arr, target);
        Console.WriteLine($"Target {arr[tIndex]} found at index {tIndex}");
    }

    public int Search(int[] arr, int target) 
    {
        //set initial high and low values
        int high = arr.Length - 1;
        int low = 0;

        //continue probing
        while (target >= arr[low] && target <= arr[high] && low <= high)
        {
            //calculate probe
            int probe = low + ((high - low) * (target - arr[low]) / (arr[high] - arr[low]));

            //if probe matches, return
            if (arr[probe] == target) return probe;

            //if probe is smaller, set new lower bound for new searchable area
            else if (arr[probe] < target) low = probe + 1;
            
            //if probe is larger, set new upper bound for new searchable area
            else high = probe - 1;
        }

        //if not found
        return -1;
    }
}
