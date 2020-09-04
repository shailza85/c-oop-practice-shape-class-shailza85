using CSharpOOP.Shapes;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape newShape = new Shape();
           

            Console.WriteLine(newShape.Area);

            Circle myCircle = new Circle(2);
            Console.WriteLine(myCircle.Radius);

            Rectangle rectangle1 = new Rectangle(10,5);
            Console.WriteLine(rectangle1.Area);
            Rectangle rectangle2 = new Rectangle(3, 5);
            Console.WriteLine(rectangle2.Perimeter);

            Triangle triangle1 = new Triangle(10,7);
            Console.WriteLine(triangle1.Area);

            Drawing mydrawing = new Drawing();
           


        }
    }
}
