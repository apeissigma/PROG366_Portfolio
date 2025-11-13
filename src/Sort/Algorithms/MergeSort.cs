using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algorithms
{
    public class MergeSort : SortingAlgo
    {
        public override string Name { get => "Merge Sort"; }

        public override void Run(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
            Display(arr); 
        }

        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; //get middle index
                Sort(arr, left, mid); //sort left subarray recursively 
                Sort(arr, mid + 1, right); //sort right subarray recursively 
                Merge(arr, left, mid, right); //merge sorted halves back together
            }
        }

        public void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1]; //temp array to store results

            int leftIndex= left;
            int rightIndex = mid + 1; 
            int tempIndex = 0;

            //compare 
            while (leftIndex <= mid && rightIndex <= right)
            {
                if (arr[leftIndex] <= arr[rightIndex]) temp[tempIndex++] = arr[leftIndex++];

                else temp[tempIndex++] = arr[rightIndex++];
            }

            while (leftIndex <= mid)
            {
                temp[tempIndex++] = arr[leftIndex++];
            }

            while (rightIndex <= right)
            {
                temp[tempIndex++] = arr[rightIndex++];
            }

            for (leftIndex = left, tempIndex = 0; leftIndex <= right; leftIndex++, tempIndex++)
            {
                arr[leftIndex] = temp[tempIndex];
            }

        }
    }
}
