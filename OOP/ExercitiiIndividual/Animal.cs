﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercitiiIndividual
{
    public class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name}, my favorite food is {FavouriteFood}.";
        }
    }
}