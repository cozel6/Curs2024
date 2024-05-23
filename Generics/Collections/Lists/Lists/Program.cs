using System.Collections;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaram lista

            List<string> list = new List<string>();
            Console.WriteLine($"Number of elements in the lists {list.Count}");

            //add elements

            list.Add("Lapte");
            list.Add("Oua");
            list.Add("salata");
            list.Add("ciocolata");

            Console.WriteLine($"Number of elements in the lists {list.Count}");

            //list.Add(3213123)
            //ArrayList oldList = new ArrayList();
            //oldList.Add("Lapte");
            //oldList.Add(12);
            //oldList.Add(new object());



            // union of list
            List<string> wifeShoppingList = new List<string> { "ciocolata" ,"cafea", "pantofi", "parfum" };

            list.AddRange(wifeShoppingList);


            //print elemenst

            foreach ( string item in list )
            {
                Console.WriteLine(item);
            }


            //sortarea listei

            Console.WriteLine();

            list.Sort();
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            //remove elements
            list.Remove("ciocolata");
            list.Remove("pantofi");

            /*
            foreach(string item in list)
            {
                if (item == "ciocolata")
                {
                    list.Remove(item);
                }
            }
            */

            list.RemoveAll(x => x == "ciocolata");


            Console.WriteLine($"Mai exista pantofi in lista {list.Contains("pantofi")}");


            // reverse items in list
            List<int> intList = new List<int> { 1, 7, 3, 4, 6, 5, 2 };
            intList.Reverse();

            Person perosn1 = new Person("Catalin" , "Popescu");
            Person perosn2 = new Person("Andrei", "Marian");

            List<Person> people = new List<Person>();
            people.Add(perosn1);
            people.Add(perosn2);

            foreach (Person person in people )
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                
            }


            Console.WriteLine(people[1].FirstName);


            people.Clear();

            Console.WriteLine($"Number of elements in the lists {people.Count}");
        }
    }
}
