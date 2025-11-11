using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class LinearHash<Value>
    {
        public HashData<Value>[] arr;
        public int size; //amount of obj in map
        public int cap = 16; //default map capacity of 16
        
        //default constructor
        public LinearHash() 
        {
            size = 0;
            arr = new HashData<Value>[cap]; 
        }

        //overloaded constructor taking a custom capacity
        public LinearHash(int capInput)
        {
            size = 0;
            cap = capInput;
            arr = new HashData<Value>[cap];
        }

        public HashData<Value> Get(int key) 
        {
            //iterate through arr; if key is found, return obj
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null && arr[i].key == key)
                {
                    return arr[i]; 
                }
            }
            return null; //key not found
        }

        public void Put(int key, Value val)
        {
            HashData<Value> temp = new HashData<Value>(key, val); //create temp dataObj
            int hashCode = Hash(key); //uses key to generate hashcode

            while (arr[hashCode] != null)  //while buckets are filled...
            {
                hashCode = (hashCode + 1) % cap; //increase the hashCode's value
            }

            if (arr[hashCode] == null) //if the bucket is empty...
            {
                arr[hashCode] = temp; //insert the obj into the map at the hashCode's position
                size++; //a new obj was added, so increment the size 
                Resize(size);
            }
        }

        public HashData<Value> Delete(int key) 
        {
            var temp = Get(key);
            arr[temp.key] = null;
            return temp; 
        }

        //generates a hashCode using the obj's key
        private int Hash(int key)
        {
            return (key.GetHashCode() & 23) % cap; 
        }

        //if the size of the map is larger than half the capacity, double the capacity
        private void Resize(int size)
        {
            if (size >= cap / 2)
            {
                cap = cap * 2;
                Array.Resize(ref arr, cap);
            }
        }

        public void About()
        {
            Console.WriteLine($"\nMap size/cap: {size}/{cap}");

            for (int i = 0; i < cap; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine($" > {arr[i].key}: {arr[i].value}");
                }
                else
                {
                    Console.WriteLine($" > {i}: --");
                }
            }
        }
    }
}
