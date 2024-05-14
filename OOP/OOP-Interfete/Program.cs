namespace OOP_Interfete
{
    /*
     * nstructions
    Model an application which contains a class Ferrari and an interface.
    Your task is simple, you have a car - Ferrari, its model is "488-Spider" and it has a driver.
    Your Ferrari should have functionality to use brakes and push the gas pedal. When the brakes are pushed down print "Brakes!", and when the gas pedal is pushed down - "Zadu6avam sA!".
    As you may have guessed this functionality is typical for all cars, so you should implement an interface to describe it.
    Your task is to create a Ferrari and set the driver's name to the passed one in the input.  After that, print the info.
    Input
    On the single input line, you will be given the driver's name.
    Output
    On the single output line, print the model, the messages from the brakes and gas pedal methods and the driver's name. In the following format:
     * 
     * 
     * 
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari.ToString());
        }
    }
}
