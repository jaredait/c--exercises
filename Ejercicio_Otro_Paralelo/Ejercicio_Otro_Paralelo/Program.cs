using System;
using System.Globalization;
using System.Collections;

namespace Ejercicio_Otro_Paralelo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] auxiliar = new string[2];
            string[,] datos;
            string lectura = string.Empty;
            int acciones = 0;
            int minimo = 100000;                // 100 000 es el maximo numero de ejercicio que un libro puede tener
            Stack pila = new Stack();
            int sacarLibro = 0;

            Console.Write("Numero de acciones: ");
            acciones = Convert.ToInt32(Console.ReadLine());
            datos = new string[acciones, 2];

            // Lectura del libro y numero de ejercicios restantes
            for (int i = 0; i < acciones; i++)
            {
                // inicializar de nuevo sacarLibro!!!
                lectura = Console.ReadLine();

                if(lectura == "-1")
                {
                    // analizar como comparar el string que devuelve pila, ya que contiene el numero de ejercicios y el nombre del libro
                    // con el int minimo
                    if(pila.Pop() != minimo)
                    continue;
                }

                pila.Push(lectura);             // Introducir en la pila el libro y # de ejercicios restantes
                auxiliar = lectura.Split(' ');
                for (int j = 0; j < 2; j++)
                {
                    datos[i, j] = auxiliar[j];
                    if(j == 0)                  // almacenar el minimo numero de ejercicios
                    {
                        if (Convert.ToInt32(datos[i, j]) < minimo)
                            int.TryParse(datos[i, j], out minimo);
                    }
                }
            }

            for (int i = 0; i < acciones; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(datos[i, j]);
                }
            }
            
            Console.WriteLine("Pila de libros:");
            foreach (string libro in pila)
                Console.WriteLine(libro);

            Console.WriteLine($"minimo = {minimo}");

        }
    }
}
