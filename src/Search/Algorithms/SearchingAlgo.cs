using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algorithms
{
    public class SearchingAlgo
    {
        public virtual string Name { get; }

        public virtual void Run(int[] arr, int target) { }

        public virtual void Search(int[] arr, int target) { }

        public void Display() 
        {
            Console.WriteLine("========== " + this.Name + " ========== ");
        }
    }
}
