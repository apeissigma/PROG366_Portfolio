using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class MaxHeap
    {
        public int[] heap; 

        public MaxHeap(int[] arr)
        {
            heap = arr;
            int n = heap.Length;

            for (int i = n/2 - 1; i >= 0; i--)
            {
                Heapify(heap, i, n);
            }
        }

        public void Heapify(int[] heap, int val, int size)
        {
            int left = 2 * val + 1;
            int right = 2 * val + 2;
            int max = val;
            
            if (left < size && heap[left] > heap[max]) max = left;

            if (right < size && heap[right] > heap[max]) max = right;

            //if i is no longer the largest, swap recursively
            if (max != val)
            {
                //swap max with current val
                var temp = heap[val];
                heap[val] = heap[max];
                heap[max] = temp;

                Heapify(heap, max, size); 
            }
        }

    }
}
