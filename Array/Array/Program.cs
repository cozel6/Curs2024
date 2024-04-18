using System.Runtime.Serialization.Formatters;

namespace Array
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
            for (int i = 0; i  < length; i++)
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
            while(index < daysOfTheWeek.Length)
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

            string[] myArrayCone = (string[]) daysOfTheWeek.Clone();
            myArrayCone[0] = "Duminica";
            Console.WriteLine(myArrayCone[0]);
            Console.WriteLine(daysOfTheWeek[0]);

            //resilze al array ului


            int[] intArray = new int[5];
            int[] copyArray = intArray; //create a backup

            intArray = new int[6];

            for (int i = 0;i < 5; i++)
            {
                intArray[i] = copyArray[i];
            }
            intArray[5] = 10;
        }
    }
}
