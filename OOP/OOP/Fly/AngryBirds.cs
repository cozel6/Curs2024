﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public class AngryBirds : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm launched by something - I'm angry Birds");
        }
    }
}
