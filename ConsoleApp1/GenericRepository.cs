using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GenericRepository<T> : IRepository<T> where T : Entity<T>

    {
        List<T> storage = new List<T>();
        List<Tuple<bool, T>> todoList = new List<Tuple<bool, T>>();
    //    List<T> add_list = new List<T>();
    //    List<T> remove_list = new List<T>();
        public void Add(T item)
        {
            if(!storage.Contains(item))
            {
                todoList.Add(new Tuple<bool, T> ( true, item ));
            }
            
        }
        public void Remove(T item)
        {
            
                todoList.Add(new Tuple<bool, T>(false, item));
            
        }
        public void Save()
        {
            foreach(var item in todoList)
            {
                if (item.Item1 == true)
                {
                    storage.Add(item.Item2);
                }
                else
                {
                    storage.Remove(item.Item2);
                }
                
            }
            todoList.Clear();
        }
        public IEnumerable<T> GetAll()
        {
            return storage;
        }
        public T GetById(int id)
        {
              for(int i = 0;i < storage.Count;i++)
            {
                T item = storage[i];
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        bool Contains(T element)
        {
            return storage.Contains(element);
        }
    }
}
