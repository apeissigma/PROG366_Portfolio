using System.Drawing;

namespace DataStructures.Map
{
    public class ChainingHash
    {
        public LinkedList<HashData>[] arr;
        int size; //amount of buckets in map
        int cap; //capacity of map

        //default constructor
        public ChainingHash() 
        {
            size = 0;
            cap = 16; //default capacity
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

        //TODO: write get method
        public HashData Get(int key) 
        {
            return null; 
        }

        public void Put(int key, string val) 
        {
            HashData temp = new HashData(key, val); //create temp dataObj
            int hashCode = Hash(temp.Value); //uses value to generate hashcode

            LinkedList<HashData> bucket = arr[hashCode];

            Node<HashData> current = bucket.Head; 
            while (current != null && current.Value.Key != key)
            {
                current = current.Next; 
            }

            if (current.Value.Key == key)
            {
                current.Value.Value = val;
            }

            bucket.AddFirst(temp);
            size++;
            Resize(size);

        }

        //TODO: write deletion method
        public HashData Delete(int key) 
        {
            return null;
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
