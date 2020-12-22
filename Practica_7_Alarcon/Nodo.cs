using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_7_Alarcon
{
    class Nodo
    {
        private double data;
        private Nodo next;

        // Constructor
        public Nodo(double newData)
        {
            Data = newData;
            Next = null;
        }

        // Propiedades de los atributos
        public double Data
        {
            get { return data; }
            set { data = value; }
        }
        public Nodo Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
