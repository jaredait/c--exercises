using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_con_Nodos_Object
{
    class Nodo_Char
    {
        private char dato;
        private Nodo_Char siguiente;

        // Constructor
        public Nodo_Char(char elDato)
        {
            Dato = elDato;
            Siguiente = null;
        }

        // Propiedades de los atributos
        public char Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }
        public Nodo_Char Siguiente
        {
            get
            {
                return siguiente;
            }
            set
            {
                siguiente = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", Dato);
        }
    }
}
