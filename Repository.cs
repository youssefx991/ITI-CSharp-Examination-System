using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Day7
{
    public class Repository<T> where T : ICloneable, IComparable<T>
    {
        public T[] values;
        public int capacity;
        public int count;
        public Repository()
        {
            capacity = 100;
            values = new T[capacity];
            count = 0;
        }

        public Repository(T[] values)
        {
            this.values = values;
            capacity = count = values.Length;
        }

        public void Add(T item)
        {
            if (count >= capacity)
                throw new Exception("Array is Full");
            values[count++] = item;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(values[i]))
                {
                    RemoveAt(i);
                }
            }

            throw new Exception($"Requested value {item} not found");
        }

        public void RemoveAt(int index)
        {
            for (int i=index; i < count-1; i++)
            {
                values[i] = values[i+1];
            }
        }

        public void Sort()
        {
            Array.Sort(values);
        }

        public void GetAll()
        {
            Console.Write("[ ");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{values[i]} ");
            }
            Console.WriteLine("]");

        }

        public object Clone()
        {
            return new Repository<T>(values);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else if (obj is Repository<T> r)
            {
                return values.Length.CompareTo(r.values.Length);
            }
            return 1;
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return values[index];
                throw new Exception("Out of bounds");
            }
            set
            {
                if (index >= 0 && index < count)
                    values[index] = value;
                throw new Exception("Out of bounds");
            }

        }
    }
}
