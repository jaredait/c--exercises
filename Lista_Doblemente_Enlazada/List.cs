using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lista_Doblemente_Enlazada
{
    class List
    {
        // Atributes
        public uint count;
        public Node Head;

        // Constructor
        public List()
        {
            Count = 0;
            Head = null;         // asign null to the head data
        }

        // Atributes properties
        private uint Count { get { return count; } set { count = value; } }
        public Boolean IsEmpty { get { return Head == null ? true : false; } }     // hacer que el nodo head apunte a null en el constructor.
        // Adds an object at the end of the list                                        // luego si es que head == null, entonces IsEmpty
        public void InsertEnd(Object theData)
        {
            if (IsEmpty)
                Head = new Node(theData);
            else
            {
                Node add = new Node(theData);
                Node temp = Head;
                while(temp.Next != null)
                    temp = temp.Next;
                temp.Next = add;
                add.Prev = temp;                
            }
            Count++;
        }

        // Adds an object at the begining of the list
        public void InsertBeg(Object theData)
        {
            if (IsEmpty)
                Head = new Node(theData);
            else
            {
                Node add = new Node(theData);
                Head.Prev = add;
                add.Next = Head;
                Head = add;
            }
            Count++;
        }

        // Print from the end to the beining
        public void PrintEtoB()
        {
            if (IsEmpty)
                Console.WriteLine("Empty list");
            else
            {
                Node auxiliar = Head;
                while (auxiliar.Next != null)           // set the node at the end of the list
                    auxiliar = auxiliar.Next;

                while(auxiliar.Prev != null)            // print from the begining
                {
                    Console.WriteLine(auxiliar.Data);
                    auxiliar = auxiliar.Prev;
                }
                Console.WriteLine(auxiliar.Data);
            }
        }

        // Print from the begining to the end
        public void PrintBtoE()
        {
            if (IsEmpty)
                Console.WriteLine("Empty list");
            else
            {
                Node temp = Head;
                while(temp.Next != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
                Console.WriteLine(temp.Data);
            }
        }

        // Removes the object at the begining of the list
        public Object RemoveBeg()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Empty list");
                return null;
            }
            else
            {
                Node temp = Head;
                // Terminar de escribir el codigo que va aqui
                // crear variable object y almacear data
                // nodo = nodo.prev
            }
        }

        // Removes the object at the end of the list
        public Object RemoveEnd()
        {
            if(IsEmpty)
            {
                Console.WriteLine("Empty list");
                return null;
            }
            else
            {
                
            }
            Node last = GetLast();
            Node newLast = last.Prev;
            newLast.Next = null;
            return last.Data;
        }

        // Returns the last node of the list
        public Node GetLast()
        {
            if (IsEmpty)
                return null;
            else
            {
                Node temp = Head;
                while (temp.Next != null)
                    temp = temp.Next;
                return temp;
            }
        }
    }
}
