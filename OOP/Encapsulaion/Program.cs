namespace Encapsulaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("50121236513", "Gigi" , "Popescu");
            Console.WriteLine(person.Salary);

            person.IncreseSalary();
            Console.WriteLine(person.Salary);

            person.GetMarried("Ionescu");
            Console.WriteLine(person.Salary);

        }
    }
}
