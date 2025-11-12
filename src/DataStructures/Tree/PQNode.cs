using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class PQNode<T>
    {
        public int key; 
        public T value; 

        public PQNode(int key, T value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
