using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyList<T>
    {
        List<T> list1 = new List<T>();
        void Add(T element)
        {
            list1.Add(element);
        }
    T Remove(int index)
        {
            T removed = list1[index];
            list1.RemoveAt(index);
            return removed;
        }
    bool Contains(T element)
        {
            return list1.Contains(element);
        }
    void Clear()
        {
            list1.Clear();
        }
    void InsertAt(T element, int index)
        { list1.Insert(index, element); }

    void DeleteAt(int index)
        { list1.RemoveAt(index); }
    T Find(int index)
        {
            return list1[index];
        }
    }
}
