using System;
using System.Drawing;
using DataStructures.LinkedList;

namespace DataStructures.Map
{
    public class ChainingHash<T>
    {
        public DataStructures.LinkedList.LinkedList<HashData<T>>[] arr;
        int size; //amount of buckets in map
        public int cap = 16; //default map capacity of 16

        //default constructor
        public ChainingHash() 
        {
            size = 0;
            arr = new DataStructures.LinkedList.LinkedList<HashData<T>>[cap];
            for (int i = 0; i < cap; i++)
            {
                arr[i] = new DataStructures.LinkedList.LinkedList<HashData<T>>();
            }
        }

        //overloaded constructor taking a custom capacity
        public ChainingHash(int capInput)
        {
            size = 0;
            cap = capInput;
            arr = new DataStructures.LinkedList.LinkedList<HashData<T>>[cap];
            for (int i = 0; i < cap; i++)
            {
                arr[i] = new DataStructures.LinkedList.LinkedList<HashData<T>>();
            }
        }

        public HashData<T> Get(int k) 
        {
            DataStructures.LinkedList.LinkedList<HashData<T>> bucket = arr[Hash(k)]; //get the bucket by hashing the key

            //iterate through the bucket
            IIterator<HashData<T>> iterator = bucket.Iterator(); 
            while (iterator.HasNext())
            {
                HashData<T> data = iterator.Next();
                if (data.key == k)
                {
                    return data;
                }
                    
            }
            return null; //return null if empty
        }

        public void Put(int k, T val) 
        {
            HashData<T> temp = new HashData<T>(k, val); //create temp dataObj
            int hashCode = Hash(temp.key); //uses value to generate hashcode

            DataStructures.LinkedList.LinkedList<HashData<T>> bucket = arr[hashCode]; //gets the bucket that the obj will be put in

            Node<HashData<T>> currentNode = bucket.Head; 
            while (currentNode != null)
            {
                currentNode = currentNode.Next; //go to next node
            }

            if (currentNode == null) //find an empty spot
            {
                bucket.AddLast(temp); //add the obj to the end of the ll
                size++;
                Resize(size, this);
            }
        }

        public HashData<T> Delete(int k) 
        {
            var temp = Get(k);

            if (temp == null)
            {
                return null; //return if not found
            }

            DataStructures.LinkedList.LinkedList<HashData<T>> bucket = arr[Hash(k)]; //get the bucket by hashing the key
            Node<HashData<T>> currentNode = bucket.Head;

            //if the head matches, delete the first obj in the ll
            if (currentNode.Value.key == k)
            {
                bucket.RemoveFirst();
                return temp; 
            }

            //iterate through the rest of the bucket
            while (currentNode.Next != null)
            {
                if (currentNode.Next.Value.key == k)
                {
                    currentNode.Next = currentNode.Next.Next; //remove the node
                }
                currentNode = currentNode.Next; //go to next node
            }
            return temp;
        }

        //generates a hashCode using the sum of ASCII values in the obj's value
        //TODO FIX
        private int Hash(int val)
        {
            return val * 23 % cap;
        }

        //if the size of the map is larger than half the capacity, double the capacity
        private void Resize(int size, ChainingHash<T> map)
        {
            if (size >= cap / 2)
            {
                cap = cap * 2;
                Array.Resize(ref arr, cap);

                //add linked lists in the newly added buckets
                for (int i = 0; i < cap; i++)
                {
                    if (map.arr[i] == null)
                    {
                        arr[i] = new DataStructures.LinkedList.LinkedList<HashData<T>>();
                    }
                }
            }
        }

        public void About()
        {
            Console.WriteLine($"\nMap size/cap: {size}/{cap}");

            for (int i = 0; i < cap; i++)
            {
                DataStructures.LinkedList.LinkedList<HashData<T>> bucket = arr[i];

                if (bucket.Head == null)
                {
                    continue; //skip empty buckets
                }

                Console.WriteLine($"Bucket {i}");

                //iterate through the bucket
                IIterator<HashData<T>> iterator = bucket.Iterator();
                while (iterator.HasNext())
                {
                    HashData<T> data = iterator.Next();
                    Console.WriteLine($" > {data.key}: {data.value}");
                }
            }
        }
        
    }

}
