using DataStructures.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sort.Algorithms
{
    public class HeapSort : SortingAlgo
    {
        public override string Name { get => "Heap Sort"; }
        private int[] heap; 


        public override void Run(int[] arr)
        {
            Sort(arr);
            Display(heap); 
        }

        public void Sort(int[] arr)
        {
            heap = arr; 
            BuildHeap(heap); //build the heap 
            int n = heap.Length;

            //sort 
            for (int i = n - 1; i > 0; i--)
            {
                //swap root and min value
                Swap(heap, 0, i);
                
                //re-heapify
                Heapify(heap, 0, i);
            }
        }

        //builds the initial unsorted heap
        public void BuildHeap(int[] heap)
        {
            int n = heap.Length;

            //heapify from last non-leaf node to root
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(heap, i, n);
            }
        }

        //maintains heap structure
        public void Heapify(int[] heap, int val, int size)
        {
            int left = 2 * val + 1;
            int right = 2 * val + 2;
            int max = val;

            //if left node is larger than maximum node, set new max
            if (left < size && heap[left] > heap[max]) max = left;

            //if right node is larger than maximum node, set new max
            if (right < size && heap[right] > heap[max]) max = right;

            //if the value is no longer the largest max, swap and re-heapify
            if (max != val)
            {
                Swap(heap, val, max);
                Heapify(heap, max, size);
            }
        }
       

        public void Swap(int[] arr, int val1, int val2)
        {
            var temp = arr[val1];
            arr[val1] = arr[val2];
            arr[val2] = temp;
        }
    }
}
