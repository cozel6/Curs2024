namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Swap<int>(5, 10);

            Person p1 = new Person();
            Person p2 = new Person();


            Swap(p1, p2);
            Swap("Cos", "Min");

            Animal animal = new Animal();
            Horse horse = new Horse();

            Swap(animal, horse);


            //CustomLists<int> myIntLists = new CustomLists<int>();
            //myIntLists.Add(5);
            //myIntLists.Add(10);
            //Console.WriteLine(myIntLists.Contains(10));


            CustomLists<Person> persons = new CustomLists<Person>();
            persons.Add(p1);
            persons.Add(p2);

            CustomLists<Animal> animals = new CustomLists<Animal>();
            CustomLists<Horse> horses = new CustomLists<Horse>();

        }
        //Swap methods

        static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /* 
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static void Swap(Person a, Person b)
        {
            Person temp = a;
            a = b;
            b = temp;

        */
        class Animal : Horse  { }
        class Horse { }

    }
}
class Person
{
}

