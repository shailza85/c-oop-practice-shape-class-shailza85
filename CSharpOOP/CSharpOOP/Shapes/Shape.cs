using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        public abstract double Perimeter { get; }
    }
}