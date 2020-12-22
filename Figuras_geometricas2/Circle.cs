using System;
using System.Collections.Generic;
using System.Text;

namespace Figures2D
{
    class Circle : Figure
    {
        // Atributes
        private double radius;
        
        // Constructors
        public Circle(double rad) : base(0) 
        {
            Radius = rad;
        }
        public Circle() : base(0) { }

        // Properties
        public double Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : 0; }
        }

        // Methods
        public double StorePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
            return Perimeter;
        }
        public double StoreArea()
        {
            Area = Math.Pow(Math.PI * Radius, 2);
            return Area;
        }
        public override string ToString()
        {
            return string.Format("{0}\nPerimeter: {1} units\nArea: {2} units\nRadius: {3}", GetType(), Perimeter, Area, Radius);
        }

    }
}
