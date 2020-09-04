using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    public class Circle : Shape
    {
        public override double Area
        {
            get
            {
                // Pi * r^2
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
        public double Circumference
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override double Perimeter => Circumference;
        /*
        Same as:
        {
            get
            {
                return Circumference;
            }
        }
        */

        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}