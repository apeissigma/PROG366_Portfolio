using DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tree
{
    public class RedBlackBST
    {
        private RedBlackNode Root;
        private int N; //number of nodes

        public int? Get(int key) => Get(Root, key);

        public int? Get(RedBlackNode node, int k) 
        { 
            //search iteratively through the tree as long as the current node exists
            while (node != null) 
            {
                //search key is smaller, search left subtree for smaller keys
                if (k < node.Key) node = node.Left;
                //search key is larger, search right subtree for larger keys
                else if (k > node.Key) node = node.Right;
                else return node.Value; //key matches, value found
            }
            return null; //no matches, not found
        }

        public bool Contains(int key)
        {
            return Get(key) != null;
        }

        public void Insert(int key, int value)
        {
            Root = Insert(Root, key, value);
            Root.IsRed = false; //root always black
        }

        private RedBlackNode Insert(RedBlackNode node, int key, int value)
        {
            if (node == null)
            {
                N++;
                return new RedBlackNode(key, value, true);
            }

            if (key < node.Key) 
                node.Left = Insert(node.Left, key, value);
            else if (key > node.Key) 
                node.Right = Insert(node.Right, key, value);
            else 
                node.Value = value; //update key

            //fix right red links
            if (IsRed(node.Right) && !IsRed(node.Left))
                node = RotateLeft(node);

            //fix two consecutive red links on left
            if (IsRed(node.Left) && IsRed(node.Left.Left))
                node = RotateRight(node);

            //flip colors if two red children exist
            if (IsRed(node.Left) && IsRed(node.Right))
                FlipColors(node);

            //update subtree size
            node.N = 1 + (node.Left?.N ?? 0) + (node.Right?.N ?? 0);

            return node;
        }

        //helper method for color check
        private bool IsRed(RedBlackNode node) => node != null && node.IsRed;


        public RedBlackNode RotateLeft(RedBlackNode node) 
        {
            //checks nulls and returns if there's nothing to rotate
            if (node == null || node.Right == null) return node;

            //make rotation and change colors
            RedBlackNode x = node.Right;
            node.Right = x.Left;
            x.Left = node;
            x.IsRed = node.IsRed;
            node.IsRed = true;

            x.N = node.N; //update subtree size
            node.N = 1 + (node.Left?.N ?? 0) + (node.Right?.N ?? 0);

            return x;
        }

        public RedBlackNode RotateRight(RedBlackNode node)
        {
            //checks nulls and returns if there's nothing to rotate
            if (node == null || node.Left == null) return node;

            //make rotation and change colors
            RedBlackNode x = node.Left;
            node.Left = x.Right;
            x.Right = node;
            x.IsRed = node.IsRed;
            node.IsRed = true;

            x.N = node.N; //update subtree size
            node.N = 1 + (node.Left?.N ?? 0) + (node.Right?.N ?? 0);

            return x;
        }

        //flip colors if a "black" parents has two "red" children nodes
        public void FlipColors(RedBlackNode node) 
        {
            if (!node.IsRed && node.Left.IsRed && node.Right.IsRed)
            {
                node.IsRed = true;
                node.Left.IsRed = false;
                node.Right.IsRed = false;
            }
        }
    }
}
