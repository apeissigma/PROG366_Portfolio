using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SampleData<T>
    {
        public T Data { get; set; }

        public SampleData(T data)
        {
            Data = data;
        }

        public IIterator<T> Iterator()
        {
            return new IteratorClass<T>();
        }
    }
}
