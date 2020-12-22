/* Clase que simula una Cola con un arreglo. Lo hace mediante la reasignacion del tamaño del arreglo cada vez que un elemento es insertado
 * o removido. NO usa un arreglo circular. Contiene otros metodos que resultan utiles para la implementacion de la cola.
 * Autor: Jared Ampudia
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cola_Test00
{
    class Cola_Resized
    {
        // Atributos
        private int[] items;
        private int index;

        // Constructor
        public Cola_Resized()
        {
            Index = 0;
            items = new int[Index];
        }
        
        // Propiedades
        protected int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        // Metodo que verifica si la cola esta vacia y devuelve un booleano
        public Boolean IsEmpty()
        {
            return items.Length == 0 ? true : false;
        }

        // Inserta un elemento a la cola
        public void Enqueue(int element)
        {
            if (Index == 0)
            {
                Array.Resize(ref items, ++Index);
                items[Index - 1] = element;
            }
            else
            {
                Array.Resize(ref items, ++Index);       // Aumenta la longitud del arreglo en 1

               // for (int i = 0; i < Index - 1; i++)   // Retoma los valores
                //    items[i] = copyItems[i];

                items[Index - 1] = element;
            }
        }

        // Remueve un elemento de la cola y lo envia al metodo que lo llamo
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue underflow");
                return -1;
            }
            else
            {
                int[] itemsCopy = new int[index];
                int result = items[0];
                itemsCopy = items;

                Array.Resize(ref items, --Index);               // Resta 1 a la longitud del arreglo.

                 for (int i = 0; i < Index; i++)                // El arreglo items retoma los valores. El elemento mas antiguo items[0] 
                    items[i] = itemsCopy[i+1];                  // es eliminado y devuelto al programa principal.

                return result;
            }       
        }

        // Devuelve el elemento mas antiguo de la cola sin removerlo
        public int Peek()
        {
            return IsEmpty() ? -1 : items[0];
        }

        // Imprime todos los elementos de la cola. Por fines didacticos los imprime junto al indice que ocupan en el arreglo
        public void Print()
        {
            Console.WriteLine("Queue elements:");
            for(int i = 0; i < Index; i++)
            {
                Console.WriteLine($"[{i}]: {items[i]}");
            }
        }

        // Devuelve el numero de elementos que se encuentran en la cola
        public int Count()
        {
            return Index;
        }
    }
}
