using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace MyStack
{
    internal class MyStack<T>
    {
        List<T> list1 = new List<T>();
        public MyStack() { }  
        int Count()
        {
            return list1.Count();
        }
        T Pop()
        {
            T popped = list1[list1.Count - 1];
            list1.RemoveAt(list1.Count - 1);
            return popped;
        }
        void Push(T parameter)
        {
            list1.Add(parameter);
        }
        
    }
}
