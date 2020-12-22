using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_con_Nodos_Object
{
    class Pila_Char
    {
        private uint contar;
        private Nodo_Char comienzo;
        private const string MENSAJE_VACIO = "La pila está vacía";
        // Constructor
        public Pila_Char()
        {
            Nodo_Char inicio = new Nodo_Char('\0');
            Comienzo = inicio;
            Contar = 0;
        }

        // Propiedades de los atributos
        public uint Contar
        {
            get
            {
                return contar;
            }
            private set
            {
                contar = value;
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
                return Contar == 0 ? true : false;
            }
        }
        
        // Push
        public void Push(char elDato)
        {
            Nodo_Char nodo = new Nodo_Char(elDato);
            nodo.Siguiente = Comienzo;
            Comienzo = nodo;
            Contar++;
        }

        // Pop
        public char Pop()
        {
            if (Vacia)
            {
                Console.WriteLine(MENSAJE_VACIO);
                return '\0';
            }
            else
            {
                Nodo_Char auxiliar = Comienzo;
                Comienzo = Comienzo.Siguiente;
                Contar--;
                return auxiliar.Dato;
            }
        }

        // Ver
        public void Ver()
        {
            if (Vacia)
                Console.WriteLine(MENSAJE_VACIO);
            else
            {
                Nodo_Char actual = Comienzo;
                while (actual.Dato != '\0')
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Siguiente;
                }
            }
            
        }

        // Eliminar
        public char[] Eliminar()
        {
            char[] arreglo = new char[Contar];
            uint longitud = Contar;
            for (int i = 0; i < longitud; i++)
                arreglo[i] = Pop();

            return arreglo;
        }
    }
}
 