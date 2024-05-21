using System.Collections;

namespace ListsCollections
{
    internal class Program
    {
        static void Main(string[] args)
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

            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car);
            myArrayList.Add(car1);

            
            */


            List<Car> cars = new List<Car>();
            cars.Add(car);
            cars.Add(car1);

            foreach (Car carss  in cars)
            {
                Console.WriteLine(carss.Make);
            }


            //Swap Methods


        }
    }
}
public class Book
{

}
public class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
}
