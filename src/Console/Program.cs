using BigO;
using DataStructures;
using DataStructures.ArtApp;
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
                Console.WriteLine("> 4:  Hash Map Demo");
                Console.WriteLine("> 5:  Linked List Demo");
                Console.WriteLine("> 6:  Sorting Application");
                Console.WriteLine("> 7:  Searching Application");
                Console.WriteLine("> 8:  Tree Strctures Demo");
                Console.WriteLine("> 9:  Quit");

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
                        QueueStackDemo qsDemo = new QueueStackDemo();
                        break;
                    case 4:
                        MapDemo mapDemo = new MapDemo(); //not working, fix 
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
                        break;
                    case 9:
                        choosing = false;
                        //exit application
                        break;
                    default:
                        Console.WriteLine("Not a valid input. Please enter a number 1-8.");
                        break;
                }

            }
        }
    }
}