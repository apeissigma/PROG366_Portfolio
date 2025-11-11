using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class HashData<Value>
    {
        public int key { get; set; }
        public Value value {  get; set; }


        public HashData(int k, Value v)
        {
            key = k;
            value = v;
        }
    }
}
