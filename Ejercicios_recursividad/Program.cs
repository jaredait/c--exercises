using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Ejercicios_recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirMenu();
            try
            {
                Console.Write("Opcion: ");
                byte opc = Convert.ToByte(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Driver1();
                        break;
                    case 2:
                        Driver2();
                        break;
                    case 3:
                        Driver3();
                        break;
                    case 4:
                        Driver4();
                        break;
                    case 5:
                        Driver5();
                        break;
                    case 6:
                        Driver6();
                        break;
                    case 7:
                        Driver7();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }

        // Imprimir menu
        static void ImprimirMenu()
        {
            Console.WriteLine("1. Rango hasta");
            Console.WriteLine("2. Rango desde hasta");
            Console.WriteLine("3. Suma hasta");
            Console.WriteLine("4. Remover todos");
            Console.WriteLine("5. Aparear");
            Console.WriteLine("6. A mayusculas");
            Console.WriteLine("7. Sumar n primeros elementos");
        }

        // OPCION 1
        // Lista de números: dado un número "n", retorna la lista de números desde el 0 hasta el n incluido.
        //  Por ejemplo: rangoHasta(5) -> [0,1,2,3,4,5]
        static int RangoHasta(int n, int temp = 0)
        {
            if (temp <= n)
            {
                if (temp == 0)
                    Console.Write("[");

                Console.Write(temp);

                if (temp == n)
                    Console.Write("]");
                else
                    Console.Write(",");

                return RangoHasta(n, temp + 1);
            }
            return temp;
        }
        // OPCION 1 driver code
        static void Driver1()
        {
            Console.WriteLine("Ingresa el tope del rango:");
            int tope = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lista:");
            RangoHasta(tope);
        }

        // OPCION 2
        // Lista de números: similar a rango, pero ahora se puede especificar el "desde".
        static int Rango(int desde, int hasta)
        {
            if (desde > hasta)
                return hasta;

            Console.WriteLine(desde);
            return Rango(desde + 1, hasta);
        }
        // OPCION 2 driver code
        static void Driver2()
        {
            Console.Write("Desde: ");
            int inicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hasta: ");
            int fin = Convert.ToInt32(Console.ReadLine());
            Rango(inicio, fin);
        }

        // OPCION 3
        // Retorna la suma de los numeros desde el 0 hasta el n.
        static int SumaHasta(int n)
        {
            if (n > 0)
                return n + SumaHasta(n-1);
            return 0;
        }
        // OPCION 3 driver code
        static void Driver3()
        {
            Console.Write("Hasta: ");
            int fin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("R = {0}", SumaHasta(fin));
        }

        // OPCION 4
        // Dada una lista y un elemento, retorna otra lista igual a la original, pero sin el "elemento" dado. En caso en que 
        // el elemento aparezca múltiples veces, lo remueve de todas. Ejemplo: remover([1,2,3,1,6,7,1,9,1], 1) -> [2,3,6,7,9]
        static List<int> RemoverTodos(List<int> list, int elemento)
        {
            if (list.Contains(elemento) == false)
                return list;

            list.Remove(elemento);
            return RemoverTodos(list, elemento);
        }
        // OPCION 4 driver code
        static void Driver4()
        {
            List<int> myList = new List<int>();
            List<int> newList = new List<int>();

            // Llenar la lista de elementos
            for (int i = 0; i < 3; i++)
                for(int j = 0; j < 5; j++)
                    myList.Add(j);

            Console.WriteLine("Contenido inicial:");
            foreach (int elem in myList)
                Console.Write("{0},", elem);

            Console.Write("\nElemento a elmimar: ");
            int aEliminar = Convert.ToInt32(Console.ReadLine());
            newList = RemoverTodos(myList, aEliminar);

            Console.WriteLine("Contenido final:");
            foreach (int elem in newList)
                Console.Write("{0},", elem);
        }

        // OPCION 5
        // lista de pares (x, y): tal que "x" pertence a "unaLista", e "y" pertenece a "otra".
        // Ejemplo: aparear([1,2,3], ['a','b','c']) -> [ (1,'a'), (2,'b'), (3,'c')]
        static Queue<object[]> Aparear(Queue<int> unaLista, Queue<char> otra, Queue<object[]> pares, int length)
        {
            if (length <= 0)
                return pares;

            object[] newPar = { unaLista.Dequeue(), otra.Dequeue() };
            pares.Enqueue(newPar);
            return Aparear(unaLista, otra, pares, length - 1);
        }
        // OPCION 5 driver code
        static void Driver5()
        {
            Queue<int> colaInt = new Queue<int>();
            Queue<char> colaChar = new Queue<char>();
            Queue<object[]> colaPares = new Queue<object[]>();

            // Llenar colas
            for (int i = 0; i < 5; colaInt.Enqueue(i++)) ;
            for (int i = 97; i < 102; colaChar.Enqueue((char)i++)) ;

            // Imprimir contenido de las colas
            Console.Write("\ncolaInt: ");
            foreach (int elem in colaInt)
                Console.Write("{0},", elem);
            Console.Write("\ncolaChar: ");
            foreach (char elem in colaChar)
                Console.Write("{0},", elem);

            // Llamada a la funcion
            Aparear(colaInt, colaChar, colaPares, colaInt.Count);

            // Impresion de los pares contenidos en la cola
            Console.Write("\ncolaPares: ");
            foreach (object[] elem in colaPares)
                Console.Write("({0},{1}),", elem[0], elem[1]);
        }

        // OPCION 6
        // Otro string igual pero en mayusculas. Acordarse que los strings también se pueden tratar como listas
        static string AMayusculas(string cadena, int index)
        {
            if (index <= 0)
                return cadena;

            return AMayusculas(cadena.Substring(0, index - 1), index - 1) + cadena.Substring(index - 1, 1).ToUpper();
        }
        // OPCION 6 driver code
        static void Driver6()
        {
            Console.WriteLine("\nIngresa una fase: ");
            string frase = Console.ReadLine();
            Console.WriteLine("\nEn mayusculas:\n{0}", AMayusculas(frase, frase.Length));
        }

        // OPCION 7
        // Realizar una función que dada una lista de números y un número N, retorna la suma de 
        // todos los N primeros elementos. Ejemplo sumarN(3, [2, 4, 6, 8, 10, 12]) -> 2+4+6 = 24
        static double SumarN(int n, Queue<double> lista)
        {
            if (n == 1)
                return lista.Dequeue();

            return lista.Dequeue() + SumarN(n - 1, lista);
        }
        // OPCION 7 driver code
        public static void Driver7()
        {
            Queue<double> miLista = new Queue<double>();
            // Llenar lista
            for (int i = 1; i < 10; miLista.Enqueue(i++)) ;
            // Imprimir contenido
            Console.WriteLine("Contenido de la lista:");
            foreach (double elem in miLista)
                Console.Write(elem + ",");
            Console.Write("\nSumar los \"n\" primeros elementos\nn = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma = {0}", SumarN(n, miLista));
        }

        // OPCION 8
        // Realizar una función que dada una lista de números retorne otra lista con los mismos números pero 
        // ordenados de menor a mayor. Pista: en una lista ordenada siempre se da que un elemento en la posición 
        // x es el mínimo de la sublista que sigue. Ej: ordenar([3,6, -1]) -> [-1,3,6]
        



    }
}
