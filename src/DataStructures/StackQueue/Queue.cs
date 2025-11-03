using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackQueue
{
    public class Queue<T>
    {
        public LinkedList<T> arr; 

        public Queue() 
        { 
            arr = new LinkedList<T>();
        }

        //add the obj to the end of the queue
        public void Enqueue(T data) 
        {
            arr.AddLast(data); 
        }

        //return and remove the first obj
        public T Dequeue() 
        {
            //throw an exception if the queue is empty
            if (arr.Head == null)
            {
                throw new InvalidOperationException();
            }

            var temp = arr.GetFirst();
            arr.RemoveFirst();
            return temp; 
        }

        //return the first obj
        public T Peek() 
        {
            //throw an exception if the queue is empty
            if (arr.Head == null)
            {
                throw new InvalidOperationException();
            }

            return arr.GetFirst();
        }

        //return the length of the queue
        public int Count()
        {
            //throw an exception if the queue is empty
            if (arr.Head == null)
            {
                return 0; 
            }

            int i = 0;

            //iterate through the queue until the all nodes are accounted for
            var currentNode = arr.Head; 
            while (currentNode != null)
            {
                i++;
                currentNode = currentNode.Next;
            }
            return i; 

        }
    }
}
