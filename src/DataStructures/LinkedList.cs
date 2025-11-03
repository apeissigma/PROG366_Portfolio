using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DataStructures
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T> { Value = data, Next = Head };
            Head = newNode;
        }

        public void RemoveFirst()
        {
            // set next node to head
            Head = Head.Next;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T> { Value = data, Next = null };

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void RemoveLast()
        {
            //if head is only element
            if (Head.Next == null)
            {
                Head = null;
                return; 
            }

            Node<T> temp = Head;
            while (temp.Next.Next != null) //checks the node after the next node
            {
                temp = temp.Next;
            }
            temp.Next = null; 
        }

        public T GetFirst()
        {
            return Head.Value; 
        }

        public T GetLast()
        {
            Node<T> temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            return temp.Value; 
        }

        public T Get(int index)
        {
            Node<T> temp = Head;

            int i = 0;

            while (i < index && temp != null)
            {
                temp = temp.Next;
                i++;
            }

            return temp.Value;
        }

        public void Set(int index, T value)
        {
            Node<T> temp = Head;
            int i = 0;

            while (i < index && temp != null)
            {
                temp = temp.Next;
                i++;
            }

            temp.Value = value;
        }

        public void Insert(int index, T value)
        {
            if (index == 0)
            {
                AddFirst(value);
                return;
            }

            Node<T> temp = Head;
            int i = 0; 

            while (i < index - 1 && temp != null)
            {
                temp = temp.Next;
                i++;
            }

            Node<T> newNode = new Node<T> { Value = value, Next = temp.Next };
            temp.Next = newNode; 
        }

        public IteratorClass<T> Iterator()
        {
            return new IteratorClass<T>(this);
        }

    }
}
