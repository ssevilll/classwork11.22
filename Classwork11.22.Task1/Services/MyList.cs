using System.Runtime.CompilerServices;

namespace Classwork11._22.Task1.Services
{
    internal class MyList<T>
    {
        List<T> obj = new();
        private T[] items;
        public int Capacity { get; set; }
        public int Count { get; set; }
        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }
        public MyList(int capacity)
        {
            Capacity = capacity;
            items = new T[0];
        }
        public void Add(T item)
        {
            if (Count < Capacity)
            {
                Array.Resize(ref items, Count + 1);
                items[Count] = item;
            }
            else
            {
                throw new IndexOutOfRangeException("List is full");
            }
        }
        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                items[i] = default(T);
            }
            Count = 0;
            Console.WriteLine("List is clear");
        }

        public bool Exists(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    items[i] = default(T);
                    Console.WriteLine("Item is removed");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        public void Reverse()
        {
            T[] reversedItems = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                reversedItems[i] = items[Count - 1 - i];
            }
            items = reversedItems;
        }


        public void IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    Console.WriteLine($"Index of item is: {i}");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        public void LastIndexOf(T item)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (items[i].Equals(item))
                {
                    Console.WriteLine($"Last index of item is: {i}");
                    return;
                }
            }
            Console.WriteLine("Item not found");
        }

        
    }
}
