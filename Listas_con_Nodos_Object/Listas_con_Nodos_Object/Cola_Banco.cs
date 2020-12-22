// NOMBRE DEL PROGRAMA: Implementacion de cola
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 16/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION:  
// FECHA DE ULTIMA MODIFICACION: 16/oct/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_con_Nodos_Object
{

    // Implementacion clase cola
    class Cola_Banco
    {
        // atributos
        private int contarCola;
        private Nodo_Char comienzo;
        private const string MENSAJE_VACIO = "La pila está vacía";

        // Costructor
        public Cola_Banco()
        {
            Nodo_Char inicio = new Nodo_Char('\0');
            Comienzo = inicio;
            ContarCola = 0;
        }
        // Propiedades de los atributos
        public int ContarCola
        {
            get
            {
                return contarCola;
            }
            private set
            {
                contarCola = value;
            }

        }
        public Nodo_Char Comienzo
        {
            get
            {
                return comienzo;
            }
            set
            {
                comienzo = value;
            }
        }
        public Boolean Vacia
        {
            get
            {
                return ContarCola == 0 ? true : false;
            }
        }

        // Retorna el numero de elementos de la cola
        public int Contar_Cola()
        {
            return ContarCola;
        }

        // Retorna un booleano indicando si la cola esta vacia
        public bool ColaVacia()
        {
            return Vacia;
        }

        // Añade un elemento a la cola
        public void PushCola(char elDato)
        {
            Nodo_Char nodo = new Nodo_Char(elDato);
            nodo.Siguiente = Comienzo;
            Comienzo = nodo;
            ContarCola++;
        }
        
        // Elimina un elemento de la cola
        public char PopCola()
        {
            if (Vacia)
            {
                Console.WriteLine(MENSAJE_VACIO);
                return '\0';
            }
            else
            {
                Nodo_Char actual = comienzo;
                Nodo_Char anterior = comienzo;

                while (actual.Siguiente != null)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                anterior.Siguiente = actual.Siguiente;
                ContarCola--;
                return actual.Dato;
            }

        }


        // Imprime los elementos de la cola
        public void VerCola()
        {
            if (Vacia)
                Console.WriteLine(MENSAJE_VACIO);
            else
            {
                Nodo_Char actual = Comienzo;
                while (actual.Siguiente != null)
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Siguiente;
                }
            }
        }

        // Elimina la cola y devuelve un arreglo con los elementos que poseia
        public char[] Eliminar()
        {
            char[] arreglo = new char[ContarCola];
            int longitud = ContarCola;
            for (int i = 0; i < longitud; i++)
                arreglo[i] = PopCola();
            
            return arreglo;
        }

        // Programa principal
        static void Main(string[] args)
        {
            Cola_Banco cola = new Cola_Banco();

            Console.WriteLine("La cola esta vacia? {0}", cola.ColaVacia());

            cola.PushCola('D');
            cola.PushCola('R');
            cola.PushCola('D');
            cola.PushCola('R');

            Console.WriteLine("Elementos cola");
            cola.VerCola();
            Console.WriteLine("Cantidad de elementos: {0}", cola.Contar_Cola());
            Console.WriteLine("La cola esta vacia? {0}", cola.ColaVacia());
            Console.WriteLine("Elementos cola despues de 2 PopCola:");
            cola.PopCola();
            cola.PopCola();
            cola.VerCola();
            Console.WriteLine(cola.Contar_Cola());

            Console.WriteLine("Elementos del arreglo luego de eliminar la cola:");
            char[] arreglo = cola.Eliminar();
            foreach (char elm in arreglo)
                Console.WriteLine(elm);
        }

    }
}
