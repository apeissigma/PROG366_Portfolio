using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class PQNode
    {
        public int key; 
        public int value; 

        public PQNode(int key, int value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
