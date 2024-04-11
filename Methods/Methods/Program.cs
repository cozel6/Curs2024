#region
//Methods
static class Program
{
    static void Main(string[] args)
    {
        /*//call methods
        PrintName();
        Console.WriteLine("Baga primu numar");
        var firstNumber = ReadFromConsole();
        *//*bool succes = int.TryParse(firstNumber, out int result);*//*


        Console.WriteLine("Baga al doilea numar");

        var secondNumber = ReadFromConsole();

        Console.WriteLine("Rezultat");
        AddNumbers(firstNumber, secondNumber);
        var resultat = ReadFromConsole();
        Console.WriteLine($"The result is {resultat}");
        */
        //DisplayNumbers(2, 170);

        //Console.WriteLine(CalcSum());
        var sum = CalcSum(1, 5, 5, 5, 5, 5, 5, 6, -55);
        Console.WriteLine(sum);
    }


    static void PrintName()
    {
        Console.WriteLine("Salut, aceasta este o metoda");
    }
    static void AddNumbers(int a, int b)
    {
        Console.WriteLine(a + b);
    }

    static int ReadFromConsole()
    {
        var line = Console.ReadLine();
        bool succes = int.TryParse(line, out int result);
        if (succes)
        {
            return result;
        }
        else
        {
            Console.WriteLine("Input is invalid");
        }
        return 0;
    }

    static void DisplayNumbers(int start = 0, int end = 100)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine($"{i}");
        }
        Console.WriteLine("End");
    }

    //varible parameters
    static long CalcSum(params int[] numbers)
    {
        long sum = 0;
        foreach(int numar in numbers)
        {
            sum += numar;
        }
        return sum;
    }
}
// void = nu are RETURN TYPE
//params = array de elemente

#region Tipuri de parametrii 
// Method() ---> fara parametri 
//Method(string a , int b) --> are 2 parametri 9 a si b)
//Method(float x = 0.0f, decimal y = 3.14d) --> parametrii opionali
//Method(params string[] elemente) - numar variabil de parametrii
#endregion
#endregion

