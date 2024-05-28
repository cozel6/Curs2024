using System.Net.Cache;

namespace AnonymusType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ref - pass by reference
            // method invocation
            int refValue = 5;
            Example1(ref refValue);
            Console.WriteLine(refValue);



            // out

            int b;
            Example2(out b);


            //int x;
            //bool isNimber = int.TryParse(Console.ReadLine(), out x);
            //Console.WriteLine(x);

            // in 
            int y = 10;
            Example3(in y);


            //generics

            char i = 'k';
            char d = 'm';
            Swap(ref i, ref d);
            Console.WriteLine(i);
            Console.WriteLine(d);



            Console.WriteLine();




            //Anonymus 

            var point = new {  X = 10,Y = 10 };

            var student = new
            {
                Name = "Student 1",
                Course = ".Net",
                Grade = 10.00
            };

            Console.WriteLine(student.Course , student.Name , student.Grade);


            var studentConcrete = new Student { Name = "Student 2", Course = ".Net", };


            var myCar = new
            {
                Make = new
                {
                    Model = "Fabia",
                    Lunchyear = 2024
                },
                Color = "red"
            };
            Console.WriteLine(myCar.Make.Model);
            Console.WriteLine(myCar.Color);




            var people = new List<Person>();
            people.Add(new Person
            {
                Age = 19,
                HairColor = "red",
                Profesion = "boss",
                ShoeSize = 44
            });
            people.Add(new Person
            {
                Age = 49,
                HairColor = "greem",
                Profesion = "camatar",
                ShoeSize = 42
            });

            var ageProfesion = people.Select(pers => new
            {
                Age =pers.Age,
                Profesion = pers.Profesion,
            }).ToList();
        }
        //method declaration

        class Student
        {
            public string Name { get; set; }
            public string Course { get; set; }
            public string Grade { get; set; }
        }


        static void Example1(ref int value)
        {
            value = 10;
        }
        static void Example2(out int value)
        {
            value = 10;
        }
        static void Example3(in int value)
        {
            // value = 10; nu poti asigna o valoare
            Console.WriteLine(value);
        }


        static void Swap<T>(ref T a ,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
