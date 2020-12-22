using System;
using System.Collections.Generic;
using System.Text;

namespace Figures2D
{
    class Square : Figure
    {
        // Atributes
        protected double edgeLength;
        protected const int NUMBER_EDGES = 4;

        // Constructor
        public Square(double edgeLen) : base(NUMBER_EDGES)
        {
            EdgeLength = edgeLen;
            Perimeter = EdgeLength * NUMBER_EDGES;
            Area = EdgeLength * EdgeLength;
        }
        public Square() : base(NUMBER_EDGES) { }

        // Properties
        public double EdgeLength
        {
            get { return edgeLength; }
            set 
            {
                edgeLength = value >= 0 ? value : 0;
                StorePerimeter();
                StoreArea();
            }
        }

        // Methods
        private void StorePerimeter()
        {
            Perimeter = EdgeLength * Edges;
        }
        private void StoreArea()
        {
            Area = EdgeLength * EdgeLength;
        }
        public override string ToString()
        {
            return String.Format("{0}\nPerimeter: {1} units\nArea: {2} units\nEdges length (x4): {3}", GetType(), Perimeter, Area, EdgeLength);
        }
    }
}
