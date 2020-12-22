using System;
using System.Globalization;

namespace Busquedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 0, 1, 2, 3, 4, 5, 6, 7, 7, 7 };
            int valor = 7;

            Console.WriteLine("Existe el elemento en el arreglo?");
            Console.WriteLine(Algoritmo.Secuencial2(vector, valor));

            Console.WriteLine("\nPrimera ocurrencia");
            Console.WriteLine("Elemento {0} se encuentra en la posicion {1}", valor, Algoritmo.Secuencial(vector, valor));

            Console.WriteLine("\nSi hay varias ocurrencias");
            Console.Write("Elemento {0} se encuentra en la(s) posicion(es): ", valor);
            foreach (int elemento in Algoritmo.Secuencial3(vector, valor))
                Console.Write("{0}, ", elemento);


        }
    }
}
