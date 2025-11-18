using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class MinPQArray<T>
    {
        public PQNode[] tree;
        public int next;
        public int cap = 7; //default cap
        


        //default constructor
        public MinPQArray() 
        {
            tree = new PQNode[cap];
            next = 1; 
        }

        //constructor taking a size argument
        public MinPQArray(int n)
        {
            tree = new PQNode[n];
            next = 1;
        }

        //add a node to the end of the tree and swim it up
        public void Enqueue(int key, int element) 
        {
            //if tree is too small, resize
            if (next >= tree.Length) Resize(); 

            //create the node at the next index
            this.tree[next] = new PQNode(key, element);

            //swim the node up from the given index
            Swim(next);
            next++;
        }

        //removes min value (root)
        public PQNode Dequeue() 
        {
            PQNode min = tree[1];
            next--;

            //move last element to root
            tree[1] = tree[next];
            tree[next] = null;

            //sink new root to correct position
            Sink(1);

            return min;
        }

        //get the root
        public int Peek()
        {
            if (tree[1] == null) return -1; 
            return tree[1].value; 
        }


        //swim nodes up tree
        public void Swim(int index)
        {
            //check if index is equal to root
            if (index == 1) return;

            while (index > 1)
            {
                var parent = GetParentNodeForIndex(index);

                //if parent is lte child, don't continue
                if (tree[parent].value <= tree[index].value) break;

                Swap(parent, index);

                index = parent; 

            }
        }


        //sink nodes down tree
        public void Sink(int index) 
        { 
            while (GetLeftChildIndex(index) < next) //check if there is at least one child
            {
                var left = GetLeftChildIndex(index);
                var right = GetRightChildIndex(index);
                var smallest = left; 

                //check if right is smaller than left
                if (right < next && tree[right].value < tree[left].value)
                {
                    smallest = right; 
                }

                //break if current node is smallest than the smallest child
                if (tree[index].value < tree[smallest].value) break; 

                Swap(index, smallest);

                index = smallest; 
            }
        }

        public int GetParentNodeForIndex(int i)
        {
            if (i == 0) return -1;
            if (i == 1) return 1;

            return i / 2; 
        }

        public int GetLeftChildIndex(int i)
        {
            return 2 * i;
        }

        public int GetRightChildIndex(int i)
        {
            return 2 * i + 1;
        }

        //double the size of the tree 
        public void Resize() 
        {
            cap = cap * 2; 
            Array.Resize(ref tree, cap);
        }

        public void Swap(int x, int y)
        {
            var temp = tree[x];
            tree[x] = tree[y];
            tree[y] = temp;
        }
    }
}
