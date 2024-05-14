using OOP_MethodHiding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_MethodHiding
{
    public class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal makes Sound");
        }
    }
}
public class Cat : Animal
{
    public new string MakeSound()
    {
        Console.WriteLine("Cat makes Sound");
        return "";
    }
}
public class Dog : Animal
{

}