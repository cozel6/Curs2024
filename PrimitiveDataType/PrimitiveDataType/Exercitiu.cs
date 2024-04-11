using System;

namespace IntegerVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign the values
            short value1 = -100;
            byte value2 = 128;
            int value3 = -3540;
            ushort value4 = 64876;
            int value6 = -1141583228;
            uint value5 = 2147483648;
            long value7 = -1223372036854775808;

            // print the values
            Console.WriteLine("Value 1: " + value1);
            Console.WriteLine("Value 2: " + value2);
            Console.WriteLine("Value 3: " + value3);
            Console.WriteLine("Value 4: " + value4);
            Console.WriteLine("Value 5: " + value5);
            Console.WriteLine("Value 6: " + value6);
            Console.WriteLine("Value 7: " + value7);

            // waiting for input
            Console.ReadLine();
        }
    }
}
