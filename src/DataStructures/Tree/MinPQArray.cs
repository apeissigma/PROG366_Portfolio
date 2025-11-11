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

        public MinPQArray() 
        {
            tree = new PQNode<T>[2];
            next = 1; 
        }

        public void Enqueue() { }

        public void Dequeue() { }

        public void Swim() { }

        public void Sink() { }

        public void Resize() { }
    }
}
