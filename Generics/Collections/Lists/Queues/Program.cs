namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> luchqueue = new Queue<string>();

            luchqueue.Enqueue("Maria");
            luchqueue.Enqueue("Gigi");
            luchqueue.Enqueue("John");
            luchqueue.Enqueue("Eva");

            Console.WriteLine($"First person in line is  {luchqueue.Peek()}");
            Console.WriteLine($"Is gigi still in queue? {luchqueue.Contains("Gigi")}");

            while( luchqueue.Count > 0)
            {
                var nextInLine = luchqueue.Dequeue();
                Console.WriteLine(nextInLine);
            }
            //or 

            luchqueue.Clear();


            // is not an index as lists -- Queue<int> ints = new Queue<int> { 1, 2 ,3 ,4} not possible

        }
    }
}
