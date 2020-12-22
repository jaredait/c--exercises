using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_con_Nodos_Object
{
    class ListaEnlazada
    {
        private Nodo comienzo;
        private uint longitud;
        public const string MENSAJE_VACIO = "Lista vacia";

        // Constructor
        public ListaEnlazada()
        {
            Comienzo = null;
            Longitud = 0;
        }

        // Propiedad del atributo
        private Nodo Comienzo
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
        public uint Longitud
        {
            get
            {
                return longitud;
            }
            private set
            {
                longitud = value;
            }
        }

        // Añadir al inicio de la lista
        public void AddInicio(Object dato)
        {
            Nodo nodo = new Nodo(dato);
            nodo.Siguiente = Comienzo;
            Comienzo = nodo;
            Longitud++;
        }

        // Añadir al final
        public void AddFinal(Object dato)
        {   
            Nodo nodo = new Nodo(dato);
            Nodo actual = Comienzo;

            if(actual == null)
            {
                nodo.Siguiente = Comienzo;
                Comienzo = nodo;
            }
            else
            {
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;

                nodo.Siguiente = actual.Siguiente;
                actual.Siguiente = nodo;
            }
            Longitud++;
        }

        // Remover inicio
        public Object RemInicio()
        {
            if (EstaVacia())
            {
                Console.WriteLine(MENSAJE_VACIO);
                return null;
            }
            else
            {
                Nodo auxiliar = comienzo;
                Comienzo = Comienzo.Siguiente;
                Longitud--;
                return auxiliar.Dato;
            }
        }

        // Imprimir lista
        public void Imprimir()
        {
            if (EstaVacia())
                Console.WriteLine(MENSAJE_VACIO);
            else
            {
                Nodo actual = Comienzo;
                while(actual != null)
                {
                    Console.WriteLine(actual.Dato);
                    actual = actual.Siguiente;
                }
            }
        }

        // Esta vacia la lista
        public Boolean EstaVacia()
        {
            return Longitud == 0 ? true : false;
        }


    }
}
