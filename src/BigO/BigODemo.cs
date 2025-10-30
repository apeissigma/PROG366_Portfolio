using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigO
{
    public class BigODemo
    {
        public BigODemo() 
        {
            //-------- Week 1 Assignment -------//

            //Constant Time O(1)
            static void Print(string s)
            {
                Console.WriteLine(s);
            }

            //Linear Time O(n)
            static bool SearchNames(string searchTerm, string[] nameArr)
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
            static void CreateGrid(int rows, int cols)
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
}
