using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_5_Alarcon
{
    class PriorityQueue
    {
        // Atributes
        private NodeInt head;
        private uint count;

        // Constructor
        public PriorityQueue()
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

        // EnqueueAscending. Adds an object (int) to the list sorted in an ascending way
        public void EnqueueAscending(int newData)
        {
            NodeInt newNode = new NodeInt(newData);
            NodeInt actualNode = head;
            NodeInt previousNode = head;

            // If the queue is empty
            if (IsEmpty)
                head = newNode;
            else
            {
                NodeInt lastNode = GetLastNode();

                // If the newData is lower than the first node's data
                if (newData <= head.Data)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    // if the newData is greater than the last node's data
                    if (newData > lastNode.Data)
                        lastNode.Next = newNode;
                    else
                    {
                        // otherwise
                        while (newData > actualNode.Data && actualNode.Next != null)
                        {
                            previousNode = actualNode;
                            actualNode = actualNode.Next;
                        }
                        previousNode.Next = newNode;
                        newNode.Next = actualNode;
                    }
                }
            }
            Count++;
        }

        // Print. Prints the objects from the begining to the end
        public void Print()
        {
            if (IsEmpty)
                Console.WriteLine("Empty queue. (Print)");
            else
            {
                NodeInt temp = head;
                while (temp.Next != null)
                {
                    Console.Write(temp.Data + ",");
                    temp = temp.Next;
                }
                Console.WriteLine(temp.Data);
            }
        }

        // GetLastNode. Returns the last node of the queue
        private NodeInt GetLastNode()
        {
            NodeInt temp = head;
            while (temp.Next != null)
                temp = temp.Next;
            return temp;
        }

        // PrintEven.Returns a string containing the even numbers separated by comas
        public string PrintEven()
        {
            string evenNumbers = string.Empty; ;
            NodeInt temp = head;
            NodeInt lastNode = GetLastNode();

            if (IsEmpty == false)
            {
                while(temp.Next != null)
                {
                    if(temp.Data %2 == 0)
                    {
                        evenNumbers += temp.Data + ",";
                    }    
                    temp = temp.Next;
                }
                if (lastNode.Data % 2 == 0)
                    evenNumbers += lastNode.Data + ",";
            }
            return evenNumbers.Substring(0, evenNumbers.Length - 1);
        }

        // PrintEven.Returns a string containing the odd numbers separated by comas
        public string PrintOdd()
        {
            string oddNumbers = string.Empty; ;
            NodeInt temp = head;
            NodeInt lastNode = GetLastNode();

            if (IsEmpty == false)
            {
                while (temp.Next != null)
                {
                    if (temp.Data % 2 != 0)
                    {
                        oddNumbers += temp.Data + ",";
                    }
                    temp = temp.Next;
                }
                if (lastNode.Data % 2 != 0)
                    oddNumbers += lastNode.Data + ",";
            }
            return oddNumbers[0..^1];
        }

        // Print odd and even numbers contained in the queue
        public void PrintOddAndEven()
        {
            Console.WriteLine("{0}\t\t{1}", PrintOdd(), PrintEven());
        }

        //AddQueue. Adds the elements (int) of the queues passed as argument to the queue which called the function
        public void LinkQueues(PriorityQueue queue1, PriorityQueue queue2)
        {
            NodeInt head1 = queue1.head;
            NodeInt head2 = queue2.head;

            while(head1 != null)
            {
                EnqueueAscending(head1.Data);
                head1 = head1.Next;
            }
            while (head2 != null)
            {
                EnqueueAscending(head2.Data);
                head2 = head2.Next;
            }
        }
    }
}
