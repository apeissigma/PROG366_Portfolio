using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class LinkedListDemo
    {
        public LinkedListDemo()
        {
            var ll = new LinkedList<int>();
            ll.AddFirst(0);
            ll.AddLast(1);
            ll.AddLast(2);
            ll.AddLast(3);
            ll.AddLast(4);

            Console.WriteLine("Iterate through the ll...");
            var iterator = ll.Iterator();
            while (iterator.HasNext())
            {
                Console.Write(iterator.Next());
            }

            Console.WriteLine("\n\nRemove first and last nodes...");
            ll.RemoveFirst();
            ll.RemoveLast();
            var iterator2 = ll.Iterator();
            while (iterator2.HasNext())
            {
                Console.Write(iterator2.Next());
            }

            Console.WriteLine("\n\nGet first: " + ll.GetFirst());
            Console.WriteLine("Get last: " + ll.GetLast());
            Console.WriteLine("Get second node: " + ll.Get(1));

            ll.Set(1, 5);
            Console.WriteLine("\nSet second node to 5: " + ll.Get(1));

            ll.Insert(1, 6);
            Console.WriteLine("\nInserted 6 before second node -- second node: " + ll.Get(1) + " third node: " + ll.Get(2));
        }
    }
}
