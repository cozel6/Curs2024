using static Lambda.Extensions;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lambda
            //lambda
            //(x => x * x);

            //count numbers 
            //classic
            int[] numbers = { 5,4,1,3,9,8,6,7,2,0};
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine($"Classic numbers {count}");

            //lambda
            var oddNumbersCount = numbers.Count(x => x % 2 == 1);
            Console.WriteLine($"Lambda numbers {oddNumbersCount}");

            //extract oddnumbers 

            var oddNumbers = numbers.Where(x => x % 2 == 1).ToArray();
            //foreach (int i in oddNumbers)
            //{
            //    Console.WriteLine(i);
            //}


            /*
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "John", LastName = "Doe", City = "New York", Country = "USA" },
                new Person { FirstName = "Jane", LastName = "Smith", City = "Los Angeles", Country = "USA" },
                new Person { FirstName = "David", LastName = "Brown", City = "London", Country = "UK" },
                new Person { FirstName = "Emily", LastName = "Johnson", City = "Toronto", Country = "Canada" },
                new Person { FirstName = "Michael", LastName = "Lee", City = "Sydney", Country = "Australia" }
            };
            */
            //count all people in USA

            //var peopleInUsa = people.Count(x => x.Country == "USA");

            // order people by country and tthen by city
            //var sortedByContry =people.OrderByDescending(x => x.City).OrderBy(x => x.Country).ToList();
            #endregion

            #region Extension Methods

            string sentence = "My awsome students";
            //static method call
            int wordCount = Extensions.WordCount(sentence);


            //extension method call

            sentence.WordCountExtension();


            var a = 10;
            var b = 5;

            if (a.GreaterThen(b))
            {
                Console.WriteLine("COoOooooL a is greater then b ");
            }

            List<Person> people = new List<Person>
        {
            new Person { FirstName = "John", LastName = "Doe", Country = "USA", City = "New York" },
            new Person { FirstName = "Jane", LastName = "Smith", Country = "Canada", City = "Toronto" },
            new Person { FirstName = "John", LastName = "Smith", Country = "USA", City = "Los Angeles" },
            new Person { FirstName = "Anna", LastName = "Taylor", Country = "USA", City = "New York" },
        };

            List<Person> filteredByCountry = people.Filter(GroupType.Country, "USA");
            Console.WriteLine("Filtered by Country (USA):");
            filteredByCountry.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} from {p.City}, {p.Country}"));

            List<Person> filteredByCity = people.Filter(GroupType.City, "New York");
            Console.WriteLine("\nFiltered by City (New York):");
            filteredByCity.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} from {p.City}, {p.Country}"));

            List<Person> filteredByFirstName = people.Filter(GroupType.FirstName, "John");
            Console.WriteLine("\nFiltered by FirstName (John):");
            filteredByFirstName.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} from {p.City}, {p.Country}"));

            List<Person> filteredByLastName = people.Filter(GroupType.LastName, "Smith");
            Console.WriteLine("\nFiltered by LastName (Smith):");
            filteredByLastName.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName} from {p.City}, {p.Country}"));
        }
        #endregion


    }
}
