using System;
using System.Collections.Generic;
using System.Text;

namespace Figures2D
{
    class Triangle : Figure
    {
        // Atributes
        protected double baseTriangle;
        protected double height;
        private const int NUMBER_EDGES = 3;
        protected double edgeA;
        protected double edgeB;
        protected double edgeC;

        // Constructors
        public Triangle() : base(NUMBER_EDGES) { }
        public Triangle(double baseT, double heightT) : base(NUMBER_EDGES)
        {
            BaseTriangle = baseT;
            Height = heightT;
        }
        public Triangle(double a, double b, double c) : base(NUMBER_EDGES)
        {
            EdgeA = a;
            EdgeB = b;
            EdgeC = c;
        }

        // Properties
        public double BaseTriangle
        {
            get { return baseTriangle; }
            set { baseTriangle = value > 0 ? value : 0; }
        }
        public double Height
        {
            get { return height; }
            set { height = value > 0 ? value : 0; }
        }
        public double EdgeA
        {
            get { return edgeA; }
            set { edgeA = value > 0 ? value : 0; }
        }
        public double EdgeB
        {
            get { return edgeB; }
            set { edgeB = value > 0 ? value : 0; }
        }
        public double EdgeC
        {
            get { return edgeC; }
            set { edgeC = value > 0 ? value : 0; }
        }

        // Methods
        public double StorePerimeter()
        {
            if (EdgeA != 0 && EdgeB != 0 && EdgeC != 0)
                Perimeter = EdgeA + EdgeB + EdgeC;
            return Perimeter;
        }
        public double StoreArea()
        {
            // Calculate the area with Heron's formula
            if (EdgeA != 0 && EdgeB != 0 && EdgeC != 0)
            {
                double semiPerimeter = StorePerimeter() / 2;
                Area = Math.Sqrt(semiPerimeter * (semiPerimeter - EdgeA) * (semiPerimeter - EdgeB) * (semiPerimeter - EdgeC));
            }
            // Calculate the area with b*h/2
            else if (BaseTriangle != 0 && BaseTriangle != 0)
                Area = BaseTriangle * Height / 2;
            return Area;
        }
        public override string ToString()
        {
            return String.Format("{0}\nPerimeter: {1} units\nArea: {2} units\nEdge A: {3} | Edge B: {4} | Edge C: {5}\nBase: {6} | Height: {7}", GetType(), Perimeter, Area, EdgeA, EdgeB, EdgeC, BaseTriangle, Height);
        }
    }
}
