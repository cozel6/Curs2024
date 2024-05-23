namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // hit to copy a line ctrl + d

            //declare dictionary
            Dictionary<string, double> studentsGreades = new Dictionary<string, double>();

            studentsGreades.Add("Marian", 10);
            studentsGreades.Add("Cosmin", 7.5);
            studentsGreades.Add("Andrei", 2);
            studentsGreades.Add("Ionut", 5);
            //studentsGreades.Add("Ionut", 5); keys in dict are unique


            foreach (var student in studentsGreades)
            {
                Console.WriteLine($"{student.Key} are nota {student.Value}");
            }
            //print all keys

            var keys = studentsGreades.Keys; //declare a var with keys

            foreach (var student in keys)
            {
                Console.WriteLine($"{student}");
            }

            //print all values

            var grades = studentsGreades.Values;
            foreach(var student in grades)
            {
                Console.WriteLine($"{student}");
            }


            //check if value exists

            //v1 change value of dictionary

            if (studentsGreades.ContainsKey("Cosmin"))
            {
                //change value

                studentsGreades["Cosmin"] = 10; // Cosmin : 10 
            }

            //v2
            double tempValue = 0;
            bool cosminExist = studentsGreades.TryGetValue("Cosmin", out tempValue);
            Console.WriteLine($"Is Cosmin in the dictionaty ? " + cosminExist);

            //Complex dict
            // in line

            Dictionary<string, List<int>> complexDict = new Dictionary<string, List<int>>()
            {
                {"Maria",new List<int>{7,8}},
                {"Ana",new List<int>() }
            };
        }
    }
}
