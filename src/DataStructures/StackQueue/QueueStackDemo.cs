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
            Console.WriteLine("\n=============== Queues Vs Stacks ===============");

            Console.WriteLine("\n===== Queue Implementation =====");
            Console.WriteLine("Stacks are data structures that store elements in a last-in, first-out (LIFO) order.");
            Console.WriteLine(" > Elements are pushed (inserted) and popped (removed) from the front of the list.");
            Console.WriteLine("Choose a queue over a stack when...");
            Console.WriteLine(" > Handling data in the order it arrives, like messages or print jobs");
            Console.WriteLine(" > Preserving sequences");
            QueueDemo();

            Console.WriteLine("\n===== Stack Implementation =====");
            Console.WriteLine("Queues are data structures that store elements in a first-in, first-out (FIFO) order.");
            Console.WriteLine("> Elements are enqueued (inserted) at the end of the list and popped (removed) from the front of the list.");
            Console.WriteLine("Choose a queue over a stack when...");
            Console.WriteLine(" > Processing data in reverse order, like executing undo operations");
            Console.WriteLine(" > Managing context");
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
