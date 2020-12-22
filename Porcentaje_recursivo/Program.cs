using System;

namespace Porcentaje_recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingresa un numero para presentar sus porcentajes");
            double num = Convert.ToDouble(Console.ReadLine());
            // Las funciones f y g realizan el mismo proceso con diferente funcionalidad
            g(0.01, num);
            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        public static double f(double n, double valor)
        {
            if (n <= 1.00)
            {
                Console.WriteLine("{0:f0}% = {1:f2}", n * 100, n * valor);
                return f(n + 0.01, valor);
            }
            else
            {
                Console.WriteLine("{0:f0}% = {1:f2}", n * 100, n * valor);
                return valor;
            }
        }
        public static double g(double n, double valor)
        {
            n+=0.01;
            if (n > 1)
            {
                Console.WriteLine("{0:f0}% = {1:f2}", n * 100, n * valor);
                return 1;
            }
            Console.WriteLine("{0:f0}% = {1:f2}", n * 100, n * valor);
            return g(n, valor);
            
        }
    }
}
