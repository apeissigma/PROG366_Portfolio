using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class BigODemo
    {
        private string[] names = [ "Anna", "Becky", "Carol", "Derek", "Eric" ];

        public BigODemo() 
        {
            Console.WriteLine("\n========================= Big O Notation Demo =========================");

            Console.WriteLine("--- Constant Time O(1) ---");
            Console.WriteLine("This function takes a integer as an input and checks if it's an even number.");
            Console.WriteLine("As long as the input is less than the maximum integer size (~2,000,000), the function will take the same amount of time.");
            Console.Write("> Input: 10. Result: ");
            Console.WriteLine(IsEven(10));

            Console.WriteLine("\n--- Linear Time O(n) ---");
            Console.WriteLine("This function takes in an array and a search term, then iteratively looks for the term in the array.");
            Console.WriteLine("It's worst-case runtime is directly proportional to the size of the input array...");
            Console.WriteLine("...if the search term is at the very end of the list, it needs to loop through the entire array to find it. ");
            Console.WriteLine("On the other hand, it's best case is O(1) if the search term is at the very beginning of the array. ");
            Console.Write("> Input: Carol. Result: ");
            Console.WriteLine(SearchNames("Carol", names));

            Console.WriteLine("\n--- Quadratic Time O(n^2) ---");
            Console.WriteLine("Nested for loops influence a runtime that grows quadratic-ly to it's input size");
            Console.WriteLine("This function creates a grid taking inputs for row and column amounts, looping thorugh each row in order to write each column. ");
            Console.WriteLine("With large enough inputs, this function is at risk of running very slowly. ");
            Console.WriteLine("> Creating a grid of 10 columns and 20 rows...");
            CreateGrid(10, 20);
        }

        //Constant Time O(1)
        //This function takes a integer as an input and checks if it's an even number.
        //As long as the input is less than the maximum integer size (~2,000,000), the function will take the same amount of time.
        private bool IsEven(int num)
        {
            return (num % 2 == 0);
        }

        //Linear Time O(n)
        //This function takes in an array and a search term, then iteratively looks for the term in the array. 
        //It's worst-case runtime is directly proportional to the size of the input array...
        //...if the search term is at the very end of the list, it needs to loop through the entire array to find it. 
        //On the other hand, it's best case is O(1) if the search term is at the very beginning of the array. 
        private bool SearchNames(string searchTerm, string[] nameArr)
        {
            foreach (string name in nameArr)
            {
                if (searchTerm == name)
                {
                    return true;
                }
            }
            return false;
        }

        //Quadratic Time O(n^2)
        //Nested for loops influence a runtime that grows quadratic-ly to it's input size
        //This function creates a grid taking inputs for row and column amounts, looping thorugh each row in order to write each column. 
        //With large enough inputs, this function is at risk of running very slowly. 
        private void CreateGrid(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write('x');
                }
                Console.Write("\n");
            }
        }
    }
}
