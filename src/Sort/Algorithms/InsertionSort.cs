namespace Sort.Algorithms
{
    public class InsertionSort : SortingAlgo
    {
        public override string Name { get => "Insertion Sort"; }

        public override void Run(int[] arr)
        {
            Sort(arr);
            Display(arr);
        }

        public override void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var key = arr[i]; //current value
                int left = i; //index of value to compare key to

                //as long as the key is smaller than the value to the left
                //swap with that value
                while (left > 0 && arr[left - 1] > key) 
                {
                    arr[left] = arr[left - 1];
                    left--; 
                }
                arr[left] = key; 
            }
        }
    }
}
