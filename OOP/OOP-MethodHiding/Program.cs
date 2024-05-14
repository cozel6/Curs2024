using OOP_MethodHiding;

namespace OOP_MethodShadowing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat1 = GetAnimal("miau");
            


            Cat cat2 = new Cat();
            cat2.MakeSound();
        }
        public static Animal GetAnimal(string sound) 
        { 
            switch (sound)
            {
                case "ham":
                    return new Dog();
                case "miau": 
                    return new Cat();
                default: return new Animal();
            }
        }

    }
}
