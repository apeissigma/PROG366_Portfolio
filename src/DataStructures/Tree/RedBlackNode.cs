using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class RedBlackNode
    {
        public int key;
        public int value;

        //subtrees
        public RedBlackNode left;
        public RedBlackNode right;

        //# of nodes in subtree
        public int n;

        //color of link from parent to this node
        public bool isRed = true;

        public RedBlackNode() { }

        public RedBlackNode(int k, int v, int n, bool color)
        {
            this.key = k;
            this.value = v;
            this.n = n;
            this.isRed = color;
        }
    }
}
