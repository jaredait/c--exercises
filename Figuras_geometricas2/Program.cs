using System;
using System.Collections.Generic;

namespace Figures2D
{
    class Program
    {
        // Change the access modifiers to private in every atribute
        static void Main(string[] args)
        {
            Square sq = new Square();
            Triangle tr = new Triangle();
            Circle cr = new Circle(1);

            // Square test
            sq.EdgeLength = 5;
            Console.WriteLine(sq);
            Console.WriteLine();

            // Triangle test
            /*
            tr.BaseTriangle = 5;
            tr.Height = 4;
            */
            tr.EdgeA = 3;
            tr.EdgeB = 3;
            tr.EdgeC = 3;
            tr.StoreArea();
            tr.StorePerimeter();
            Console.WriteLine(tr);
            Console.WriteLine();

            // Circle test
            cr.StoreArea();
            cr.StorePerimeter();
            Console.WriteLine(cr);

            List<Figure> li = new List<Figure>();
            li.Add(cr);
            li.Add(tr);
            li.Add(sq);

            Console.WriteLine("\n\nPolymorphism\n");
            foreach (Figure fig in li)
                Console.WriteLine(fig + "\n");

            Console.ReadKey();
        }
    }
}
