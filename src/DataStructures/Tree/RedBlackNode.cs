using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class RedBlackNode
    {
        public int Key;
        public int Value;

        //subtrees
        public RedBlackNode Left;
        public RedBlackNode Right;

        //# of nodes in subtree
        public int N;

        //color of link from parent to this node
        public bool IsRed = true;

        public RedBlackNode() { }

        public RedBlackNode(int k, int v, bool color)
        {
            this.Key = k;
            this.Value = v;
            this.IsRed = color;
        }
    }
}
