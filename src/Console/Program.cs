using BigO;
using DataStructures.ArtApp;
using DataStructures.Graph;
using DataStructures.LinkedList;
using DataStructures.Map;
using DataStructures.StackQueue;
using DataStructures.Tree;
using Search;
using Shuffle;
using Sort;

namespace PROG366_Portfolio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== PROG366 Portfolio ==================");
            bool choosing = true;

            while (choosing)
            {
                Console.WriteLine("\n\n------------------------------------ MENU ------------------------------------");
                Console.WriteLine("> 1:  Big O Notation Demo");
                Console.WriteLine("> 2:  Fisher-Yates Shuffle Application");
                Console.WriteLine("> 3:  Data Structures (Maps & Arrays, Stacks & Queues)");
                Console.WriteLine("> 4:  Hash Map Demo (Chaining & Linear Hash Maps)");
                Console.WriteLine("> 5:  Linked List Demo");
                Console.WriteLine("> 6:  Sorting Application");
                Console.WriteLine("> 7:  Searching Application");
                Console.WriteLine("> 8:  Tree Structures Demo: Priority Queue");
                Console.WriteLine("> 9:  Tree Structures Demo: Red/Black Tree");
                Console.WriteLine("> 10:  Graph Demo");
                Console.WriteLine("> 11:  Quit");

                Console.Write("\nSelect a project to run: ");
                string choiceStr = Console.ReadLine().Trim();
                int choice = 0;

                try { choice = Int32.Parse(choiceStr); }
                catch (FormatException) { Console.WriteLine("Please enter a valid number"); }

                Console.Clear(); 

                switch (choice)
                {
                    case 1:
                        BigODemo bigODemo = new BigODemo();
                        break;
                    case 2:
                        Forecast forecast = new Forecast();
                        break;
                    case 3:
                        MapVsArrayDemo maDemo = new MapVsArrayDemo(); 
                        StackVsQueueDemo qsDemo = new StackVsQueueDemo();
                        break;
                    case 4:
                        MapDemo mapDemo = new MapDemo(); 
                        break;
                    case 5:
                        LinkedListDemo llDemo = new LinkedListDemo();
                        break;
                    case 6:
                        SortDemo sortDemo = new SortDemo();
                        break;
                    case 7:
                        SearchDemo searchDemo = new SearchDemo();
                        break;
                    case 8:
                        //pq demo
                        break;
                    case 9:
                        RedBlackBSTDemo treeDemo = new RedBlackBSTDemo(); 
                        break;
                    case 10:
                        GraphDemo graphDemo = new GraphDemo(); 
                        break;
                    case 11:
                        choosing = false;
                        //exit application
                        break;
                    default:
                        Console.WriteLine("Not a valid input. Please enter a number 1-11.");
                        break;
                }

            }
        }
    }
}