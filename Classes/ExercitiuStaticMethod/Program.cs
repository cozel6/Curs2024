namespace ExercitiuStaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string command = Console.ReadLine();
            while (!command.Equals("End"))
            {
                string[] values = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                HowManyBeer.BuyBeer(int.Parse(values[0]));
                HowManyBeer.DrinkBeer(int.Parse(values[1]));
                command = Console.ReadLine();
            }
            Console.WriteLine($"{HowManyBeer.beersInStok} {HowManyBeer.beersDrankCount}");*/


            for (int i = 4; i < 7; i++)

            {

                Console.WriteLine(++i);

            }
        }
    }
}
