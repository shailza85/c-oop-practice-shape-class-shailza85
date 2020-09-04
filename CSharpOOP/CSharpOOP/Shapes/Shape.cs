using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP.Shapes
{
public class Shape      //Base class
    {
        //Create a “Shape” class with an Area property (public getter only) that must be overwritten by derived classes.

      
        public virtual double Area { get; }
        
    }
}
