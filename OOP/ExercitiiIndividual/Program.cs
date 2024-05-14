namespace ExercitiiIndividual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Cat cat = new Cat("Whiskers", "tuna");
                Console.WriteLine(cat.ExplainSelf());

                Dog dog = new Dog("Buddy", "bones");
                Console.WriteLine(dog.ExplainSelf());
            }
        }
    }
}
