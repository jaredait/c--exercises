// NOMBRE DEL PROGRAMA: Implementacion de pilas con listas enlazadas
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
    // Definicion de la clase Nodo_Object
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

    class Pila_Object
    {
        // atributos
        private int length;
        private Nodo_Object inicio;

        // constructor
        public Pila_Object()
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

        // Añade un nodo a la pila
        public void Push(Object elDato)
        {
            Nodo_Object nodo = new Nodo_Object(elDato);
            nodo.Siguiente = Inicio;
            Inicio = nodo;
            Length++;
        }

        // Retira un nodo de la pila y devuelve el dato que almacena
        public Object Pop()
        {
            if(IsEmpty)
            {
                Console.WriteLine("La pila esta vacia. No es posible el Pop.");
                return null;
            }
            else
            {
                Nodo_Object auxiliar = Inicio;
                Inicio = Inicio.Siguiente;
                Length--;
                return auxiliar.Dato;
            }
        }

        // Imprime por consola los datos de los nodos de la pila
        public void Print()
        {
            Nodo_Object porImprimir = Inicio;
            while(porImprimir.Dato != null)
            {
                Console.WriteLine(porImprimir.Dato);
                porImprimir = porImprimir.Siguiente;
            }
        }

        // Elimina la cola y devuelve un arreglo con los elementos que almacenaba la cola
        public Object[] Delete()
        {
            Object[] array = new object[Length];
            int limit = Length;

            for (int i = 0; i < limit; i++)
                array[i] = Pop();

            return array;
        }
    }

    // Definicion del programa principal
    class Programa_Principal
    {
        static void Main(string[] args)
        {
            Pila_Object pila = new Pila_Object();

            Console.Title = "Implementacion de Pilas - Jared Ampudia";

            Console.WriteLine("Esta vacia la cola? {0}", pila.IsEmpty);
            Console.WriteLine("Nodos que almacena la cola: {0}", pila.Length);
            pila.Push('a');
            pila.Push('b');
            pila.Push('c');
            pila.Push('d');
            pila.Push('e');
            pila.Push('f'); 
            pila.Push('x');

            Console.WriteLine("\nPila luego de agregar elementos:");
            pila.Print();

            Console.WriteLine("Esta vacia la pila? {0}", pila.IsEmpty);
            Console.WriteLine("Nodos que almacena la pila: {0}", pila.Length);

            Console.WriteLine("\nPop {0}\nPop {1}", pila.Pop(), pila.Pop());
            Console.WriteLine("Pila luego de efectuar 2 Pop:");
            pila.Print();

            Object[] arr = pila.Delete();
            Console.WriteLine("\nElementos del arreglo luego de eliminar la pila:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("[{0}]: {1}", i, arr[i]);

            Console.WriteLine("Esta vacia la pila? {0}", pila.IsEmpty);
            Console.WriteLine("Nodos que almacena la pila: {0}", pila.Length);
            Console.ReadKey();
        }
    }
}
