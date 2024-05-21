using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CustomLists<T> where T : class
    {
        private List<T> values;





        public CustomLists()
        {
            values = new List<T>();
        }

        public void Add(T item)
        {
            values.Add(item);
        }

        public void Remove(T item)
        {
            values.Remove(item);
        }

        public bool Contains(T item)
        {
            return values.Contains(item);
        }
    }
}
