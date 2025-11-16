using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sort.Algorithms
{
    public class BubbleSort : SortingAlgo
    {
        
        public override string Name { get => "Bubble Sort"; }
        public bool notSorted;

        public override void Run(int[] arr)
        {
            Sort(arr);
            Display(arr);
        }

        public override void Sort(int[] arr)
        {
            notSorted = true; 

            while (notSorted)
            {
                //preemptively mark the set as sorted
                notSorted = false;

                //iterate down the set
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    //compare adjacent values
                    if (arr[i] < arr[i - 1])
                    {
                        //swap adjacent values
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;

                        //since the set was found to be unsorted, mark it as unsorted
                        notSorted = true; 
                    }
                }
            }
        }
    }
}
