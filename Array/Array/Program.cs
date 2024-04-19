using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare new array
            int[] myArray = new int[3]; // size of the array
            myArray[0] = 35; // am assignat la pozitia 0 nr 35
            myArray[1] = -10;
            myArray[2] = 500;
            //myArray[4] = 625; <-- System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'

            myArray[1] = 95015;


            string[] daysOfTheWeek = { "Luni", "Marti", "Joi", "Sambata" }; // reprezentare inline

            //accesing elements in array
            string[] reverseDays = new string[6];
            int length = daysOfTheWeek.Length;
            for (int i = 0; i < length; i++)
            {
                reverseDays[length - i - 1] = daysOfTheWeek[i];
            }


            // Console.WriteLine(reverseDays[0]);
            //for loop
            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine(daysOfTheWeek[i]);
            } // asa poti printa un array 
            //sau
            //foreach

            foreach (string item in daysOfTheWeek)
            {
                //Console.WriteLine(item);
            }

            //while
            int index = 0;
            while (index < daysOfTheWeek.Length)
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }

            // la do se executa doar o bucata de cod
            index = 0;
            do
            {
                //Console.WriteLine(daysOfTheWeek[index]);
                index++;
            }
            while (index < daysOfTheWeek.Length);



            //citim de la consola un array

            //Console.WriteLine("Please give an array size");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] myArrayFromConsole = new int[arraySize];
            //Console.WriteLine("Please input the values of the array:");
            //for (int i = 0;i < arraySize; i++)
            {
                //myArrayFromConsole[i] = int.Parse(Console.ReadLine());
            }

            // coping an array

            string[] myArayCoppy = daysOfTheWeek;
            myArayCoppy[0] = "Alabala";
            Console.WriteLine(myArayCoppy[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            string[] myArrayCone = (string[])daysOfTheWeek.Clone();
            myArrayCone[0] = "Duminica";
            Console.WriteLine(myArrayCone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            //resilze al array ului


            int[] intArray = new int[5];
            int[] copyArray = intArray; //create a backup

            intArray = new int[6];

            for (int i = 0; i < 5; i++)
            {
                intArray[i] = copyArray[i];
            }
            intArray[5] = 10;

            //matrix

            //declare and create matrix
            int[] array = new int[2];
            array[0] = 1;
            int[,] myMatrix = {
                {1, 2},
                {2, 3}
            };

            int[,] myMatrix2 = new int[2, 2];  // o matrice de 2 pe 2
            myMatrix2[0, 0] = 1;
            myMatrix2[0, 1] = 5;
            //printing a matrix

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < myMatrix.GetLength(1); column++)
                {
                    Console.Write(myMatrix[row, column]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }

            //reading a matrix form console

            /*Console.WriteLine("Hai sa definim matricea");

            Console.WriteLine("Scrie numarul de randuri");
            int nrRanduri = int.Parse(Console.ReadLine());
            Console.WriteLine("Scrie numarul de coloane");
            int nrColoane = int.Parse(Console.ReadLine());

            int[,] matriceaMea = new int[nrRanduri, nrColoane];

            Console.WriteLine("Hai sa definim valorile:");
            for (int i = 0; i < nrRanduri; i++)
            {
                for (int k = 0; k < nrColoane; k++)
                {
                    Console.WriteLine("Scrie valoarea pentru randul " + i + " si coloana " + k + ":");
                    matriceaMea[i, k] = int.Parse(Console.ReadLine());
                }
            }*/
            //jagged array 
            //Jagged arrays = este un array de array uri
            int[][] jagged2 = new int[3][];


            //Properties of Class array
            string[] capitals = { "Sofia", "Bucuresti", "Londra", "Paris" };
            Console.WriteLine($"Lungimea este de {capitals.Length}");
            Console.WriteLine($"Numarule de dimensiuni este de {capitals.Rank}");
            Console.WriteLine($"Numarule de dimensiuni este de{myMatrix2.Rank}");




            Console.WriteLine($"Pozitia orasului londra este {System.Array.IndexOf(capitals,"Londra")}");

            //array reverse
            var reversed = capitals.Reverse(); // le da reverse (de la coada la cap)
            foreach ( var city in reversed)
            {
                Console.WriteLine(city);
            }

            Array.Sort(capitals); //le sorteaza alfabetic
            foreach (var city in capitals)
            {
                Console.WriteLine($"Capiutalele sortate {city}");
            }
            Console.WriteLine(capitals[2]);

            //Array.Clear(capitals);
            //Array.Sort(capitals);
        }
    }
}
