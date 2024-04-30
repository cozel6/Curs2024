using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public class Bird : IBird //IFlyable , ILandBound
    {
        public bool Migrates {
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public void Fly()
        {
            Console.WriteLine("Flap flap , I'm a bird and I fly");
        }
        public void Walk()
        {
            Console.WriteLine("Bird walking!");
        }
        public void Sing()
        {
            Console.WriteLine("Singing, waking up people!");
        }



    }
}
