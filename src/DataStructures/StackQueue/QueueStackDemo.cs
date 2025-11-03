using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackQueue
{
    public class QueueStackDemo
    {
        public QueueStackDemo()
        {
            Console.WriteLine("\n===== Queue Implementation =====");
            QueueDemo();
            Console.WriteLine("\n===== Queue Implementation =====");
            StackDemo();
        }

        public void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Queuing 1, 2, 5");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(5);

            Console.WriteLine($"Peek first item: {queue.Peek()}");
            Console.WriteLine($"Dequeue first item: {queue.Dequeue()}");
            Console.WriteLine($"Peek first item: {queue.Peek()}");
        }

        public void StackDemo()
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Pushing 1, 2, 5");
            stack.Push(1);
            stack.Push(2);
            stack.Push(5);

            Console.WriteLine($"Peek first item: {stack.Peek()}");
            Console.WriteLine($"Pop first item: {stack.Pop()}");
            Console.WriteLine($"Peek first item: {stack.Peek()}");
        }
    }
}
