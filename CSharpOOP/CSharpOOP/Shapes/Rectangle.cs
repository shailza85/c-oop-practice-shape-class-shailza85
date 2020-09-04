﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
    public class Rectangle : Shape
    {
        public override double Area => Length * Width;

        public override double Perimeter => Length * 2 + Width * 2;

        private double Length { get; set; }

        private double Width { get; set; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
    }

}