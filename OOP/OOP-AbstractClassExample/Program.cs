namespace OOP_AbstractClassExample
{

    /*
     *
     *Create class hierarchy, starting with abstract class Shape:
    Abstract methods:
    CalculatePerimeter(): doulbe
    CalculateArea(): double
    Virtual methods:
    Draw(): string
    Extend Shape class with two children:
    Rectangle
    Circle
    Each of them need to have:
    Fields:
    height and width for Rectangle
    radius for Circle
    Encapsulation for these fields
    Public constructor
    Concrete methods for calculations (perimeter and area)
    Override methods for drawing
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10.0, 7.0);
            Console.WriteLine(rectangle.Draw());
            Console.WriteLine($"Perimetrul {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Perimetrul {rectangle.CalculateArea()}");

            Shape circle = new Circle(10.0);
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Perimetrul {circle.CalculatePerimeter()}");
            Console.WriteLine($"Perimetrul {circle.CalculateArea()}");
        }
    }
}
