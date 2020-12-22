using System;
using System.Collections.Generic;
using System.Text;

namespace Figures2D
{
    class Figure
    {
        // Atributes
        protected double area;
        protected double perimeter;
        protected int edges;
        private const byte DEFAULT_PERIMETER = 0;
        private const byte DEFAULT_AREA = 0;
        private const byte DEFAULT_EDGES = 0;

        // Constructors
        public Figure(int edg)
        {
            Edges = edg;
            Perimeter = DEFAULT_PERIMETER;
            Area = DEFAULT_AREA;
        }
        public Figure() : this(0) { }

        // Properties
        public virtual double Area
        {
            get { return area; }
            set { area = value >= 0 ? value : DEFAULT_AREA; }
        }
        public virtual double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value >= 0 ? value : DEFAULT_PERIMETER; }
        }
        protected int Edges
        {
            get { return edges; }
            set { edges = value >= 0 ? value : DEFAULT_EDGES; }
        }
    }
}
