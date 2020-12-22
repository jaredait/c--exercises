using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_recursive_methods_implementation
{
    class Stack
    {
        // Properties
        private Node Top { get; set; }
        public int Count { get; private set; }

        // Constructor
        public Stack()
        {
            Top = null;
            Count = 0;
        }

        // METHODS

        // Push
        public void Push(object obj)
        {
            Node newTop = new Node(obj);
            newTop.Next = Top;
            Top = newTop;
        }
        private Node Push(object obj, Node temp, int count)
        {
            
        }


    }
}
