﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog
    {
        private readonly string name;
        public Dog(string name)
        {
            Console.WriteLine("Dog Class");
            this.name = name;
        }

        public virtual void Bark() //permite prin virtual sa "suprascrie" lucruri existente
        {
            Console.WriteLine("Dog - Ham Ham");
        }
        public void Eat()
        {
            Console.WriteLine("Yum Yum");
        }


    }
}
