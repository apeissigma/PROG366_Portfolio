using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class HashData<T>
    {
        public int key { get; set; }
        public T value {  get; set; }


        public HashData(int k, T v)
        {
            key = k;
            value = v;
        }
    }
}
