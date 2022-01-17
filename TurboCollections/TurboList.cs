using System;
using System.Threading.Channels;

namespace TurboCollections
{
    public class TurboList<T>
    {
        public int Count => items.Length;
        private T[] items = Array.Empty<T>();
        public TurboList()
        {
            Console.WriteLine("Hello, TurboBoomer!");
        }

        public void Add(T item)
        {
            //Rezising Array
            T[] newArray = new T[Count + 1];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = items[i];
            }
            //Assign new element
            items[Count] = item;
            //Assign the result to our field
            items = newArray;
        }

        public T Get(int index)
        {
            return items[index];
        }

        void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                //item.add
            }
        }
        public void Remove(T item)
        {
        }
        public void Clear()
        {
        }

        public bool Contains(T item)
        {
            return true;
        }
    }
    
}
