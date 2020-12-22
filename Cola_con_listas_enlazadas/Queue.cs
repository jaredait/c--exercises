using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_con_listas_enlazadas
{
    class Queue
    {
        // Atributes
        private Node head;
        private uint count;

        // Constructor
        public Queue()
        {
            head = null;
            Count = 0;
        }

        // Atributes' properties
        public uint Count
        {
            get { return count; }
            private set { count = value; }
        }
        public Boolean IsEmpty
        {
            get { return Count == 0 ? true : false; }
        }

        // Enqueue. Adds an object to the end of the queue
        public void Enqueue(object newData)
        {
            Node newNode = new Node(newData);
            if (IsEmpty)
                head = newNode;
            else
            {
                Node lastNode = GetLastNode();
                lastNode.Next = newNode;
            }
            Count++;
        }

        // Dequeue. Removes the object at the begining of the queue. Returns its content
        public object Dequeue()
        {
            object myData;
            if (IsEmpty)
            {
                Console.WriteLine("Empty queue. (Dequeue)");
                myData = null;
            }
            else
            {
                myData = head.Data;
                head = head.Next;
                Count--;
            }
            return myData;                
        }

        // Print. Prints the objects from the begining to the end
        public void Print()
        {
            if (IsEmpty)
                Console.WriteLine("Empty queue. (Print)");
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
                Console.WriteLine(temp.Data);
            }
        }

        //Returns the object at the begining of the queue without removing it
        public object Peek()
        {
            object obj;
            if (IsEmpty)
                obj = null;
            else
                obj = head.Data;

            return obj;
        }


        // GetLastNode. Returns the last node of the queue
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            return temp;
        }
    }
}
