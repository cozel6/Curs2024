namespace Collections.ArrayLists;

using System;
using System.Collections;

internal class Program
{
    public void Main(string[] args) // Changed to static
    {
        Car car = new Car();
        car.Make = "Toyota";
        car.Model = "Yaris";

        Car car1 = new Car();
        car1.Make = "VW"; // Corrected from car.Make
        car1.Model = "Touran";

        Car[] myCars = new Car[2];
        myCars[0] = car;
        myCars[1] = car1;

        ArrayList myArrayList = new ArrayList();
        myArrayList.Add(car);
        myArrayList.Add(car1);

        foreach (Car cars in myArrayList)
        {
            Console.WriteLine(cars.Make);
        }
    }
}

public class Book
{
    // Assuming some properties and methods here
}

public class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
}
