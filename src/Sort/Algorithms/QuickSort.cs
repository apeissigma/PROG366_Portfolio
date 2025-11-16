using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algorithms
{
    public class QuickSort : SortingAlgo
    {
        public override string Name { get => "Quick Sort"; }
        public override void Run(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
            Display(arr); 
        }

        public void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivot = Parititon(arr, low, high); //partition the array to get the pivot's index
                Sort(arr, low, pivot - 1); //sort left subarray recursively
                Sort(arr, pivot + 1, high); //sort right subarray recursively
            }

        }

        public int Parititon(int[] arr, int low, int high)
        {
            int pivot = arr[high]; //choose the last value as te pivot

            int smallIndex = low - 1; //track the index of smaller values by starting one position before the low index

            //iterate through all elements from low to high - 1
            for (int i = low; i <= high - 1; i++)
            {
                //check if current element is smaller than the pivot
                if (arr[i] < pivot)
                {
                    smallIndex++;
                    Swap(arr, smallIndex, i);
                }
            }

            Swap(arr, smallIndex + 1, high); //swap pivot
            return smallIndex + 1; //return the pivot's new position

        }

        public void Swap(int[] arr, int low, int high)
        {
            var temp = arr[low]; 
            arr[low] = arr[high];
            arr[high] = temp;
        }
    }
}
