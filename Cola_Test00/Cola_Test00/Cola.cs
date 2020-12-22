// Esta clase es la que el profesor nos dio como referencia.

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Cola_Test00
{
    class Cola
    {
        // Atributos
        public const int MAXQUEUE = 5;
        private int front;
        private int rear;
        private int[] items;

        public Cola()
        {
            items = new int[MAXQUEUE];
            Front = MAXQUEUE - 1;
            Rear = MAXQUEUE - 1;
        }

        // Propiedades. Getters y setters
        public int Front
        {
            get
            {
                return front;
            }
            set
            {
                front = value;
            }
        }
        public int Rear
        {
            get
            {
                return rear;
            }
            set
            {
                rear = value;
            }
        }

        public Boolean IsEmpty()
        {
            return Front == Rear ? true : false;
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue underflow");
                return 0;
            }
            if (Front == MAXQUEUE - 1)
                Front = 0;
            else
                Front++;

            int aux = items[Front];
            items[Front] = 0;

            return aux;
        }
        
        public void Insert(int value)
        {
            if (Rear == MAXQUEUE - 1)
                Rear = 0;
            else
                Rear++;
            if (Rear == Front)
            {
                Console.WriteLine("queue overflow");
                Rear--;
            }
            else
                items[Rear] = value;
        }

        public void Print()
        {
            int elemento = Front;
            Console.WriteLine("Elementos pila:");
            if (IsEmpty())
                Console.WriteLine("empty");
            else
            {
                if (elemento == MAXQUEUE - 1)
                    elemento = 0;
                else
                    elemento++;
                while (elemento <= Rear)
                {
                    Console.WriteLine(items[elemento]);
                    elemento++;
                }  
            }
        }
    }
}
