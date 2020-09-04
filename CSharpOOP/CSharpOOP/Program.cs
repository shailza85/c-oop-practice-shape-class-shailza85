using CSharpOOP.Shapes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing myDrawing = new Drawing();
            myDrawing.Draw(new Circle(4.2, Shape.ColourValue.Green));
            Console.WriteLine(myDrawing);
        }

    }
}