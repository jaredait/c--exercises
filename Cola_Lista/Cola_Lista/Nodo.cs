using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_Char
{
    class Nodo
    {
        // Atributos de la clase nodo
        private char dato;
        private Nodo siguiente;

        // Constructor
        public Nodo(char elDato)
        {
            Dato = elDato;
            Siguiente = null;
        }

        // Propiedades de los atributos
        public char Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
