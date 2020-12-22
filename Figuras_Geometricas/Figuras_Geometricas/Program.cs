using System;

namespace Figuras_Geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado fig1 = new Cuadrado(5);
            Cuadrado fig2 = new Cuadrado(4);
            Triangulo fig3 = new Triangulo(1, 2);
            Triangulo fig4 = new Triangulo(3, 4);

            Figura2D[] figuras = new Figura2D[4];

            figuras[0] = fig1;
            figuras[1] = fig2;
            figuras[2] = fig3;
            figuras[3] = fig4;

            foreach (Figura2D figura in figuras)
            {
                Console.WriteLine(figura);
                Console.WriteLine("Area: {0}", figura.CalcularArea());
            }

        }
    }
}
