// NOMBRE DEL PROGRAMA: Implementacion de colas con listas enlazadas
// NOMBRE DEL ESTUDIANTE: Ampudia Jared
// CURSO: 3er nivel
// PARALELO: 1
// FECHA DE ENTREGA: 19/oct/2020
// PROPOSITO DE ULTIMA MODIFICACION: generar codigo desde cero
// FECHA DE ULTIMA MODIFICACION: 17/oct/2020

using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_Lista
{
    /*
    class Nodo_Object
    {
        // Atributos de la clase nodo
        private Object dato;
        private Nodo_Object siguiente;

        // Constructor
        public Nodo_Object(Object elDato)
        {
            Dato = elDato;
            Siguiente = null;
        }

        // Propiedades de los atributos
        public Object Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo_Object Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
    */
    // Definicion de la clase Cola_Object
    class Cola_Object
    {
        // atributos
        private int length;
        private Nodo_Object inicio;

        // constructor
        public Cola_Object()
        {
            Length = 0;
            Inicio = new Nodo_Object(null);
        }

        // propiedades de los atributos
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public bool IsEmpty
        {
            get { return Length == 0 ? true : false; }
        }
        public Nodo_Object Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        // Inserta un nodo en la cola
        public void Enqueue(Object elDato)
        {
            Nodo_Object nuevo = new Nodo_Object(elDato);

            if (IsEmpty)
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
            }
            else
            {
                Nodo_Object actual = Inicio;
                Nodo_Object anterior = Inicio;
                while (actual.Dato != null)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                nuevo.Siguiente = actual;
                anterior.Siguiente = nuevo;
            }
            Length++;
        }

        // Elimina el dato mas antiguo de la cola y retorna el dato que almacenaba
        public Object Dequeue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Cola vacia, no es posible retirar un nodo.");
                return null;
            }
            Nodo_Object auxiliar = Inicio;
            Inicio = Inicio.Siguiente;
            Length--;
            return auxiliar.Dato;
        }

        // Imprime todos los elementos de la cola
        public void Print()
        {
            if (IsEmpty)
                Console.WriteLine("Cola vacia. No es posible imprimir.");
            else
            {
                Nodo_Object porImprimir = Inicio;
                while (porImprimir.Dato != null)
                {
                    Console.WriteLine(porImprimir.Dato);
                    porImprimir = porImprimir.Siguiente;
                }
            }
        }

        // Elimina la cola y devuelve un arreglo con los elementos que almacenaba la cola
        public Object[] Delete()
        {
            Object[] array = new Object[Length];
            int limit = Length;

            for (int i = 0; i < limit; i++)
                array[i] = Dequeue();

            return array;
        }
    }
    /*
    // Definicion del programa principal
    class Programa_Principal
    {
        static void Main(string[] args)
        {
            Cola_Object cola = new Cola_Object();

            Console.Title = "Implementacion de Colas - Jared Ampudia";

            Console.WriteLine("Esta vacia la cola? {0}", cola.IsEmpty);
            Console.WriteLine("Nodos que almacena la cola: {0}", cola.Length);
            cola.Enqueue('a');
            cola.Enqueue('b');
            cola.Enqueue('c');
            cola.Enqueue('d');
            cola.Enqueue('e');
            cola.Enqueue('f');
            cola.Enqueue('x');
            Console.WriteLine("\nCola luego de agregar elementos:");
            cola.Print();

            Console.WriteLine("Esta vacia la cola? {0}", cola.IsEmpty);
            Console.WriteLine("Nodos que almacena la cola: {0}", cola.Length);

            Console.WriteLine("\nDequeue {0}\nDequeue {1}", cola.Dequeue(), cola.Dequeue());
            Console.WriteLine("Cola luego de efectuar 2 Dequeue:");
            cola.Print();

            Object[] arr = cola.Delete();
            Console.WriteLine("\nElementos del arreglo luego de eliminar la cola:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("[{0}]: {1}", i, arr[i]);

            Console.WriteLine("Esta vacia la cola? {0}", cola.IsEmpty);
            Console.WriteLine("Nodos que almacena la cola: {0}", cola.Length);
            Console.ReadKey();
        }
    }*/
}
