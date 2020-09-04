using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    // Example of Inheritance
    public class Triangle : Shape
    {
        public override double Area => Height * Width / 2;
        public override double Perimeter => Height + Width + Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2));

        // Example of Abstraction
        private double Height { get; set; }

        private double Width { get; set; }

        // Example of Encapsulation
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}