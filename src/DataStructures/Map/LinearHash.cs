using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Map
{
    public class LinearHash
    {
        public HashData[] arr;
        public int size; //amount of obj in map
        public int cap = 16; //default map capacity of 16
        
        //default constructor
        public LinearHash() 
        {
            size = 0;
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
                if (arr[i] != null && arr[i].Key == key)
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
                    Console.WriteLine($" > {arr[i].Key}: {arr[i].Value}");
                }
                else
                {
                    Console.WriteLine($" > {i}: --");
                }
            }
        }
    }
}
