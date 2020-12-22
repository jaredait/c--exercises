using System;
using System.Collections.Generic;
using System.Text;

namespace Cola_Test00
{
    class ColaPQ
    {
        // Variables de instancia
        private Persona[] items;
        private int index;
        Persona pNull = new Persona("null");

        // Constructor
        public ColaPQ()
        {
            Index = 0;
            items = new Persona[Index];
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
        public Boolean EstaVacia()
        {
            return items.Length == 0 ? true : false;
        }

        public void Insertar(Persona element)
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
            OrdenarInsercion();
        }

        public Persona Remover()
        {
            if (EstaVacia())
            {
                Console.WriteLine("queue underflow");
                return pNull;
            }
            else
            {
                Persona [] itemsCopy = new Persona[index];
                Persona result = items[0];
                itemsCopy = items;

                Array.Resize(ref items, --Index);               // Resta 1 a la longitud del arreglo.

                for (int i = 0; i < Index; i++)                // El arreglo items retoma los valores. El elemento mas antiguo items[0] 
                    items[i] = itemsCopy[i + 1];                  // es eliminado y devuelto al programa principal.

                return result;
            }
        }

        public Persona Tope()
        {
            return EstaVacia() ? pNull : items[0];
        }

        public void Imprimir()
        {
            Console.WriteLine("Queue elements:");
            for (int i = 0; i < Index; i++)
            {
                Console.WriteLine($"[{i}]: {items[i]}");
            }
        }

        public int Contar()
        {
            return Index;
        }

        private void OrdenarInsercion()
        {
            Persona pre = new Persona();
            Persona pos = new Persona();
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    pre = items[j - 1];
                    pos = items[j];
                    if (pre.Edad > pos.Edad)
                    {
                        Persona temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }
    }
}