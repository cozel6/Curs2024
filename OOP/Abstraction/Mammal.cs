﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Mammal
    {
        public bool HasWarmBlood { get { return true; } }
        public void GiveBirth()
        {

        }


        public void Breastfeeding() 
        {
            Console.WriteLine("I'am a mammal and I breasfeed my cub");
        }

    }
}
