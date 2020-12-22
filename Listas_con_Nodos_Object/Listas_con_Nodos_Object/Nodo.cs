using System;
using System.Collections.Generic;
using System.Text;

namespace Listas_con_Nodos_Object
{
    class Nodo
    {
        private Object dato;
        private Nodo siguiente;

        // Constructor
        public Nodo(Object elDato)
        {
            Dato = elDato;
            Siguiente = null;
        }

        // Propiedades de los atributos
        public Object Dato
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
        public Nodo Siguiente
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


    }
}
