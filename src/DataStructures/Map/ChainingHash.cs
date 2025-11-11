using System;
using System.Drawing;

namespace DataStructures.Map
{
    public class ChainingHash<Value>
    {

        //FIXING MAPS TO INCLUDE GENERICS, WILL BE WORKING AGAIN SOON...

        /*
        public LinkedList<HashData<Value>>[] arr;
        int size; //amount of buckets in map
        public int cap = 16; //default map capacity of 16

        //default constructor
        public ChainingHash() 
        {
            size = 0;
            arr = new LinkedList<HashData>[cap];
            for (int i = 0; i < cap; i++)
            {
                arr[i] = new LinkedList<HashData>();
            }
        }

        //overloaded constructor taking a custom capacity
        public ChainingHash(int capInput)
        {
            size = 0;
            cap = capInput;
            arr = new LinkedList<HashData>[cap];
            for (int i = 0; i < cap; i++)
            {
                arr[i] = new LinkedList<HashData>();
            }
        }

        public HashData Get(int key) 
        {
            LinkedList<HashData> bucket = arr[Hash(key)]; //get the bucket by hashing the key

            //iterate through the bucket
            IIterator<HashData> iterator = bucket.Iterator(); 
            while (iterator.HasNext())
            {
                HashData data = iterator.Next();
                if (data.Key == key)
                {
                    return data;
                }
                    
            }
            return null; //return null if empty
        }

        public void Put(int key, string val) 
        {
            HashData temp = new HashData(key, val); //create temp dataObj
            int hashCode = Hash(temp.Key); //uses value to generate hashcode

            LinkedList<HashData> bucket = arr[hashCode]; //gets the bucket that the obj will be put in

            Node<HashData> currentNode = bucket.Head; 
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

        public HashData Delete(int key) 
        {
            var temp = Get(key);

            if (temp == null)
            {
                return null; //return if not found
            }

            LinkedList<HashData> bucket = arr[Hash(key)]; //get the bucket by hashing the key
            Node<HashData> currentNode = bucket.Head;

            //if the head matches, delete the first obj in the ll
            if (currentNode.Value.Key == key)
            {
                bucket.RemoveFirst();
                return temp; 
            }

            //iterate through the rest of the bucket
            while (currentNode.Next != null)
            {
                if (currentNode.Next.Value.Key == key)
                {
                    currentNode.Next = currentNode.Next.Next; //remove the node
                }
                currentNode = currentNode.Next; //go to next node
            }
            return temp;
        }

        //generates a hashCode using the sum of ASCII values in the obj's value
        private int Hash(int val)
        {
            return val * 23 % cap;
        }

        //if the size of the map is larger than half the capacity, double the capacity
        private void Resize(int size, ChainingHash map)
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
                        arr[i] = new LinkedList<HashData>();
                    }
                }
            }
        }

        public void About()
        {
            Console.WriteLine($"\nMap size/cap: {size}/{cap}");

            for (int i = 0; i < cap; i++)
            {
                LinkedList<HashData<Value>> bucket = arr[i];

                if (bucket.Head == null)
                {
                    continue; //skip empty buckets
                }

                Console.WriteLine($"Bucket {i}");

                //iterate through the bucket
                IIterator<HashData> iterator = bucket.Iterator();
                while (iterator.HasNext())
                {
                    HashData<Value> data = iterator.Next();
                    Console.WriteLine($" > {data.Key}: {data.Value}");
                }
            }
        }
          */
    }

}
