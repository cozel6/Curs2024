﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fly
{
    public class PaperAirplane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'M A LAUNCHED BY a human hand'");
        }
    }
}
