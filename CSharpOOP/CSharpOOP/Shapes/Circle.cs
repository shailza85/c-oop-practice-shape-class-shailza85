using System;
using System.Collections.Generic;
using System.Text;
using CSharpOOP.Shapes;

namespace CSharpOOP.Shapes
{
    /*Create a “Circle” class that inherits from Shape with the following properties:
    Circumference(public getter only)
    Area(public getter only)
    Radius(private getter and setter)
    */

    public class Circle : Shape //Circle class inherits from Shapes
    {

        public int Circumference { get; }

       private int _radius;
        public int Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }

        //Create constructors for all three shapes that require their private properties as arguments.

        public Circle(int radius)
        {
            this.Radius = Radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return Radius * Radius * System.Math.PI;
            }
        }
    }
}
