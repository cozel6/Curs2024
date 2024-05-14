using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_AbstractClassExample
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public Rectangle(double height, double width) 
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
           return 2 * (width + height);
        }
        public override string Draw()
        {
            return "Desenam un patrat: ";
        }
    }
}
