using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algorithms
{
    public abstract class SortingAlgo
    {
        public virtual string Name { get; }
        public virtual void Run(int[] arr) { }

        public virtual void Sort(int[] arr) { }

        public void Display(int[] arr)
        {
            Console.WriteLine("========== " + this.Name + " ========== ");

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
