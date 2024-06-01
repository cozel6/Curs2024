using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
        public void Remove(int index)
        {
            if(index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException("index out of range");
            }
            items.RemoveAt(index);
        }
        public bool Contains(T item)
        {
            return items.Contains(item);
        }
    }
}
