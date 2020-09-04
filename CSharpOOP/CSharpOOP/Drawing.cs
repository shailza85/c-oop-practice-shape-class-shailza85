using System;
using System.Collections.Generic;
using System.Text;
using CSharpOOP.Shapes;
using System.Linq;

namespace CSharpOOP
{
    public class Drawing
    {

        /*
         * Create a “Drawing” class in the root assembly (not “.Shapes”) that has the following properties and methods:
            SpaceCovered (public getter only), which will get the total area of all shapes drawn.
            LinesDrawn (public getter only), which will get the total perimeter/circumference of all shapes drawn.
            Shapes (private getter and setter), polymorphic list
            Draw(Shape), which will accept a polymorphic argument and add that to the Shapes list.
            A ToString() override, which will output “A drawing consisting of X shapes.” where X is the number of shapes in the polymorphic list.

          */
        public int SpaceCovered { get; }
        public int LinesDrawn { get; }

         List<Shape> Shapes { get; set; }


        public Drawing()
        {
            Shapes = new List<Shape>();
        }
        public void Draw(Shape newShape)
        {
            Shapes.Add(newShape);
            Console.WriteLine(Shapes.Where(x=>x.GetType()==typeof(Circle)).Count());
        }

        public override string ToString()
        {
            
           return $" The drawing has : {Shapes.Count()} shapes";
        }

    }
}
