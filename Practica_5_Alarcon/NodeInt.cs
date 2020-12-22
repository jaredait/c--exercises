using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_5_Alarcon
{
    class NodeInt
    {
        private int data;
        private NodeInt next;

        // Constructor
        public NodeInt(int newData)
        {
            Data = newData;
            Next = null;
        }

        // Propiedades de los atributos
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public NodeInt Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
