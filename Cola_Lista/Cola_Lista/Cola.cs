using Cola_Char;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cola_Lista
{
    class Cola
    {
        // atributos
        private int length;
        private Nodo inicio;

        // constructor
        public Cola()
        {
            Length = 0;
            Inicio = new Nodo('\0');
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
        public Nodo Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        // Inserta un nodo en la cola
        public void Push(char elDato)
        {
            Nodo nuevo = new Nodo(elDato);

            if (IsEmpty)
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
            }
            else
            {
                Nodo actual = Inicio;
                Nodo anterior = Inicio;
                while(actual.Dato != '\0')
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
        public char Pop()
        {
            if(IsEmpty)
            {
                Console.WriteLine("Cola vacia, no es posible el Pop");
                return '\0';
            }
            Nodo auxiliar = Inicio;
            Inicio = Inicio.Siguiente;
            Length--;
            return auxiliar.Dato;
        }

        // Imprime todos los elementos de la cola
        public void Print()
        {
            if (IsEmpty)
                Console.WriteLine("Cola vacia. No es posible imprimir");
            else
            {
                Nodo porImprimir = Inicio;
                while(porImprimir.Dato != '\0')
                {
                    Console.WriteLine(porImprimir.Dato);
                    porImprimir = porImprimir.Siguiente;
                }
            }
        }

        // Elimina la cola y devuelve un arreglo con los elementos que almacenaba la cola
        public char[] Delete()
        {
            char[] array = new char[Length];
            int limit = Length;

            for (int i = 0; i < limit; i++)
                array[i] = Pop();

            return array;
        }
    }
}
