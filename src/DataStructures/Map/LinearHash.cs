using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class LinearHash
    {
        HashData[] arr;
        int size; //amount of obj in map
        int cap; //capacity of map
        
        //default constructor
        public LinearHash() 
        {
            size = 0;
            cap = 16; //default capacity
            arr = new HashData[cap]; 
        }

        //overloaded constructor taking a custom capacity
        public LinearHash(int capInput)
        {
            size = 0;
            cap = capInput;
            arr = new HashData[cap];
        }

        public HashData Get(int key) 
        {
            //iterate through arr; if key is found, return obj
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Key == key)
                {
                    return arr[i]; 
                }
            }
            return null; //key not found
        }

        public void Put(int key, string val)
        {
            HashData temp = new HashData(key, val); //create temp dataObj
            int hashCode = Hash(temp.Value); //uses value to generate hashcode

            while (arr[hashCode] != null)  //while buckets are filled...
            {
                hashCode = (hashCode + 1) % cap; //increase the hashCode's value
            }

            if (arr[hashCode] == null) //if the bucket is empty...
            {
                temp.Key = hashCode;
                arr[temp.Key] = temp; //insert the obj into the map at the hashCode's position
                size++; //a new obj was added, so increment the size 
            }

            Resize(size); 
        }

        public HashData Delete(int key) 
        {
            var temp = Get(key);
            arr[temp.Key] = null;
            size--;
            Resize(size);
            return temp; 
        }

        //generates a hashCode using the sum of ASCII values in the obj's value
        private int Hash(string val)
        {
            int k = 0;
            char[] arr = val.ToCharArray();
            foreach (char c in arr)
            {
                k += (int)c; 
            }

            return k * 23 % cap; 
        }

        private void Resize(int size)
        {
            if (size >= cap / 2)
            {
                cap = size * 2;
                Array.Resize(ref arr, cap);
                Console.WriteLine($"Array has been resized to {arr.Length}({cap})");
            }
            else if (size <= cap / 2)
            {
                cap = size / 2;
                Array.Resize(ref arr, cap);
                Console.WriteLine($"Array has been resized to {arr.Length}({cap})");
            }
        }
    }
}
