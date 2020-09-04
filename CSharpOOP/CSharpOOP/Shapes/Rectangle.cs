using System;
using System.Collections.Generic;
using System.Text;
using CSharpOOP.Shapes;

namespace CSharpOOP.Shapes
{
    public class Rectangle : Shape       //Rectangle class inherits from Shapes
    {
        /*
         * Create a “Rectangle” class that inherits from Shape with the following properties:
            Perimeter (public getter only)
            Area (public getter only)
            Length (private getter and setter)
            Width (private getter and setter)
         **/

        private int _perimeter;
        public int Perimeter
        {
            get
            {
                return _perimeter;
            }

            set
            {
                _perimeter = 2*(Length+Width);
            }
        }
        //public double Area { get; set; }

        private int _length;
        private int Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        private int _width;
        private int Width
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        //Create constructors for all three shapes that require their private properties as arguments.

        public Rectangle(int Width, int Length)
        {
            this.Width = Width;
            this.Length = Length;
         
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return Width * Length;
            }
        }
    }
}
