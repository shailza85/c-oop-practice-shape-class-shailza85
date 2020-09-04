using CSharpOOP.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpOOP
{
    class Drawing
    {
        public double SpaceCovered
        {
            get
            {
                return Shapes.Select(x => x.Area).Sum();
            }
        }
        public double LinesDrawn
        {
            get
            {
                return Shapes.Select(x => x.Perimeter).Sum();
            }
        }
        // Example of Polymorphism
        private List<Shape> Shapes { get; set; }

        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }

        public override string ToString()
        {
            return $"A drawing consisting of {Shapes.Count} shapes.";
        }
    }
}