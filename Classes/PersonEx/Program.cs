using Classes;

namespace PersonEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 20);
            Person mary = new Person("Mary", 18);
            Person nick = new Person("Nick", 43);

            Console.WriteLine($"{john.Name}, {john.Age}");
            Console.WriteLine($"{mary.Name}, {mary.Age}");
            Console.WriteLine($"{nick.Name}, {nick.Age}");

            

        }
    }
}
