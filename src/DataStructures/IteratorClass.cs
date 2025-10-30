using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class IteratorClass<T> : IIterator<T>
    {
        private Node<T> dataNode;
        private int count;

        public IteratorClass()
        {
            count = 0;
        }

        public IteratorClass(LinkedList<T> linkedList)
        {
            this.dataNode = linkedList.Head;
            count = 0;
        }

        public bool HasNext()
        {
            return dataNode != null; 
        }

        public T Next()
        {
            //Returns next element and increments iterator
            if (dataNode == null)
            {
                Console.WriteLine("No more elements");
            }

            T current = dataNode.Value;
            dataNode = dataNode.Next; //set to next
            return current;
        }
    }

}
