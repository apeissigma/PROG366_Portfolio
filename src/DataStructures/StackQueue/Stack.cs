using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackQueue
{
    public class Stack<T>
    {
        public LinkedList<T> arr;

        public Stack() 
        { 
            arr = new LinkedList<T>();
        }

        //add the obj to the beginning of the stack
        public void Push(T data) 
        { 
            arr.AddFirst(data);
        }

        //return and remove the first obj
        public T Pop() 
        {
            //throw an exception if the stack is empty
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
            //throw an exception if the stack is empty
            if (arr.Head == null)
            {
                throw new InvalidOperationException();
            }

            return arr.GetFirst();
        }

        public int Count()
        {
            //throw an exception if the stack is empty
            if (arr.Head == null)
            {
                return 0; 
            }

            int i = 0;

            //iterate through the stack until the all nodes are accounted for
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
