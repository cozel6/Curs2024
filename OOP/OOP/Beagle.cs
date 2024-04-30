using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Beagle : Dog // o mosteneste
    {
        public string Name { get { return Name; } }
        public Beagle(string name) : base(name)
        {
            Console.WriteLine("Beagle - ctor");
        }

        public void DoTrick()
        {
            Console.WriteLine("I'm doing tricks!");
        }

        public void Bark()
        {
            Console.WriteLine("Beagle Bark");
        }
    }
}
