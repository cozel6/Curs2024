namespace HandoutListAndStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("How many numbers you want ? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number: ");

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            Console.WriteLine("Reversed number are");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            */

            // from file

            Stack<int> readFromFile = new Stack<int>();

            string filePath = "textFile1.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not exist");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);


            foreach (string line in lines)
            {
                int number = int.Parse(line);
                readFromFile.Push(number);
            }
            Console.WriteLine("The int from file are");

            while(readFromFile.Count > 0)
            {
                Console.WriteLine(readFromFile.Pop());
            }
        }

    }
}
