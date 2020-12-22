using System;
using System.Collections.Generic;
using System.Text;

namespace Pila_con_listas_enlazadas
{
    class Stack
    {
        // Atributes
        private Node head;
        private uint count;

        // Constructor
        public Stack()
        {
            head = null;
            count = 0;
        }

        // Atributes' properties
        public uint Count 
        { 
            get { return count; } 
            private set { count = value; }
        }
        public Boolean IsEmpty
        {
            get { return head == null ? true : false; }
        }

        // Push. Inserts an object at the top of the stack
        public void Push(Object newData)
        {
            Node newNode = new Node(newData);
            newNode.Next = head;
            head = newNode;
            Count++;
            Console.WriteLine("Push data: {0}", newNode.Data);
        }

        // Pop. Removes the newest (the top) Node in the stack and returns its object
        public Object Pop()
        {
            if(IsEmpty)
            {
                Console.WriteLine("Empty stack. (Pop)");
                return null;
            }
            else
            {
                Object myData = head.Data;
                head = head.Next;
                Count--;
                return myData;
            }
        }

        // Print. Prints the stack objects from the top to the bottom
        public void Print()
        {
            if (IsEmpty)
                Console.WriteLine("Empty stack. (Print)");
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
                Console.WriteLine(temp.Data);               // Prints the data of the last node of the stack. If there's only 1 node, prints its data
            }
        }

        // GetLastNode. Returns the last node of the stack. Null if it's empty
        public Node GetLastNode()
        {
            if (IsEmpty)
                return null;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                return temp;
            }
        }

        // GetSecondToLastNode. Returns the second to last node of the stack, null if its empty
        public Node GetSecondToLastNode()
        {
            if (IsEmpty)
                return null;
            else
            {
                Node temp = head;

                if (temp != GetLastNode())
                    while (temp.Next != GetLastNode())
                        temp = temp.Next;

                return temp;
            }
        }

        // Peek. Returns the object of the newest (the top) node without removing it. Null if its empty
        public Object Peek()
        {
            Object myData;
            if (IsEmpty)
            {
                Console.WriteLine("Empty list. (Peek)");
                myData = null;
            }
            else
                myData = head.Data;
            return myData;
        }

        // Delete. Returns an array of the objects within the list through Pops and deletes the list
        public Object[] Delete()
        {
            Object[] array = new object[Count];
            if(IsEmpty)
            {
                Console.WriteLine("Empty list. (Delete)");
                array = null;
            }
            else
            {
                int i = 0;
                while(IsEmpty == false)
                {
                    array[i] = Pop();
                    i++;
                }
            }
            return array;
        }
        
    }
}
