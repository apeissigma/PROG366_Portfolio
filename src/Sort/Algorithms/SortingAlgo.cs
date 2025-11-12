using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Algorithms
{
    public abstract class SortingAlgo
    {
        public string Name; 
        public virtual void Run(int[] arr) { }
    }
}
