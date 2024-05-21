using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercises
{
    public class Box<T>
    {
        private List<T> elements;


        public Box()
        {
            elements = new List<T> ();
        }
        public void Add(T element)
        {
            elements.Add(element);
        }
        public  T Remove()
        {
            if (elements.Count == 0)
            {
                return default(T); //retruneaza valaorea deafult lui T 
            }
            T element = elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return element;
        }
        
        public int Count
        {
            get { return elements.Count; }
        }
    }

}
