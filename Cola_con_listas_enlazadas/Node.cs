using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_con_listas_enlazadas
{
    class Node
    {
        private Object data;
        private Node next;

        // Constructor
        public Node(Object newData)
        {
            Data = newData;
            Next = null;
        }

        // Propiedades de los atributos
        public Object Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}
