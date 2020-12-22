using System;

namespace Figures2D
{
    class Program
    {
        // Change the access modifiers to private in every atribute
        static void Main(string[] args)
        {
            Square sq = new Square();
            Triangle tr = new Triangle();

            sq.EdgeLength = 5;
            Console.WriteLine(sq);
            Console.WriteLine();

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

            Console.ReadKey();
        }
    }
}
