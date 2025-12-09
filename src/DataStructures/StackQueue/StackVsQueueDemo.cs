using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.StackQueue
{
    public class StackVsQueueDemo
    {
        string filePath = $"..\\..\\..\\..\\DataStructures\\Data\\DataStructuresData.txt";

        public StackVsQueueDemo()
        {
            Console.WriteLine("\n========================= Stacks Vs Queues =========================");
            Console.WriteLine("*** See README.md for data structure information and comparisons ***");

            Console.WriteLine("\n===== Stack Implementation =====");
            StackDemo();

            Console.WriteLine("\n===== Queue Implementation =====");
            QueueDemo();
        }

        public void QueueDemo()
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Enqueuing Data (values 1-501)");
            var data = File.ReadAllLines(filePath);
            foreach (var line in data) { queue.Enqueue(Int32.Parse(line)); }

            Console.WriteLine($" > Peek the queue: {queue.Peek()}"); //will return the first value in the queue
            Console.WriteLine($" > Dequeue from the queue: {queue.Dequeue()}"); //will return the first value in the queue and remove it
            Console.WriteLine($" > Peek the queue: {queue.Peek()}"); //will return the NEW first value in the queue
        }

        public void StackDemo()
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Pushing Data (values 1-501)");
            var data = File.ReadAllLines(filePath);
            foreach (var line in data) { stack.Push(Int32.Parse(line)); }

            Console.WriteLine($" > Peek the stack: {stack.Peek()}"); //will return the last value in the stack
            Console.WriteLine($" > Pop off the stack: {stack.Pop()}"); //will return the last value in the stack and remove it
            Console.WriteLine($" > Peek the stack: {stack.Peek()}"); //will return the NEW last value in the stack
        }
        
    }
}
