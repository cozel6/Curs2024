namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare elements

            Stack<string> cities = new Stack<string>();

            //add elements
            cities.Push("1. Iasi");
            cities.Push("2. Cluj");
            cities.Push("3. Brasov");
            cities.Push("4. Bucuresti");

            //check the las element
            Console.WriteLine($"Last element is: {cities.Peek()}");


            cities.Pop();
            Console.WriteLine($"Last element is: {cities.Peek()}");

            while (cities.Count > 0)
            {
                Console.WriteLine(cities.Pop());
            }
        }
    }
}
