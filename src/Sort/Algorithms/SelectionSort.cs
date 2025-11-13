using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algorithms
{
    public class SelectionSort : SortingAlgo
    {
        public override string Name { get => "Selection Sort"; }

        public override void Run(int[] arr)
        {
            Sort(arr);
            Display(arr);
        }

        public override void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //find minimum value
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                //swap
                var temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp; 
            }
        }
    }
}
