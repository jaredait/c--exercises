using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Doblemente_Enlazada
{
    class Node
    {
        // Atributes
        private Object data;
        private Node prev;
        private Node next;

        // Constructor
        public Node(Object data)
        {
            Prev = null;
            Next = null;
            Data = data;
        }

        // Atributes properties
        public Object Data { get { return data; } set { data = value; } }
        public Node Prev { get { return prev; } set { prev = value; } }
        public Node Next { get { return next; } set { next = value; } }
    }
}
