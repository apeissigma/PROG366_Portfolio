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
        }

        public override void Sort(int[] arr)
        {
            notSorted = true; 

            while (notSorted)
            {
                notSorted = false; 
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        var temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;

                        notSorted = true; 
                    }
                }
            }
            Display(arr);
        }
    }
}
