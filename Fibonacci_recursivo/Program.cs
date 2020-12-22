using System;

namespace Fibonacci_recursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nTerminos;

            try
            {
                Console.Write("Ingresa el numero de terminos que deseas ver\nn = ");
                nTerminos = Convert.ToUInt32(Console.ReadLine());

                if (nTerminos == 0)
                    throw new System.Exception();

                Console.WriteLine("Serie:");
                for (int i = 0; i < nTerminos; i++)
                {
                    Console.Write("{0}", Fibonacci(i));
                    if (i != nTerminos - 1)
                        Console.Write(", ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error, ingresa un numero entero mayor que 0");
            }
            
        }

        // 0 1 1 2 3 5 8 13 21
        public static int Fibonacci(int n)
        {
            if(n == 0 || n == 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
