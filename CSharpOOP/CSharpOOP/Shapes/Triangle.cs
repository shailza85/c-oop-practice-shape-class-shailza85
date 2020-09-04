using System;
using System.Collections.Generic;
using System.Text;
using CSharpOOP.Shapes;

namespace CSharpOOP.Shapes
{
    public class Triangle : Shape   //Triangle class inherits from Shapes
    {

        /*
         * Create a “Triangle” class that inherits from Shape with the following properties:
            Perimeter (public getter only)
            Area (public getter only)
            Width (private getter and setter)
            Height (private getter and setter)

         */

        private int _perimeter;
        public int Perimeter
        {
            get
            {
                return _perimeter;
            }

            set
            {
                _perimeter = value;
            }
        }
        //public double Area { get; set; }

        private int _width;
        private int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        private int _height;
        private int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }


        //Create constructors for all three shapes that require their private properties as arguments.

        public Triangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
            //this.Area = (Height * Width / 2);
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return (Height * Width / 2);
            }

        }
    }
}
