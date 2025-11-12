using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class MinPQArray<T>
    {
        public PQNode<T>[] tree;
        int next;
        int size = 0;
        int cap = 2; //default cap

        //default constructor
        public MinPQArray() 
        {
            tree = new PQNode<T>[cap];
            next = 1; 
        }

        public MinPQArray(int n)
        {
            tree = new PQNode<T>[n];
            next = 1;
        }

        public void Enqueue(int key, T element) 
        {
            //if tree is too small, resize
            if (size + 1 >= cap) Resize(); 

            //create the node at the next index
            this.tree[next] = new PQNode<T>(key, element);

            //swim the node up from the given index
            Swim(next);
            next++;
            size++;
        }

        //removes the min/root value
        public void Dequeue() { }

        public T Peek()
        {
            return this.tree[0].value; 
        }

        public void Swim(int index) 
        {
            //check if index is equal to root
            if (index == 1) return; 

            //check parent node and see if it is less than current current key
            //if so swap
            
            //while parent node 
        }

        public void Sink() { }

        public void Resize() 
        {
            cap = cap * 2; 
            Array.Resize(ref tree, cap);
        }
    }
}
