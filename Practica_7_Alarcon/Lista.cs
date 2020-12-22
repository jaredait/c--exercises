using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_7_Alarcon
{
    class Lista
    {
        // Atributos
        Nodo head;

        // Constructor
        public Lista()
        {
            head = null;
        }

        //Propiedades
        public bool EstaVacia
        {
            get { return head == null ? true : false; }
        }

        // AñadirInicio. Inserta un nuevo nodo al inicio de la lista. El parametro es el dato que almacena el nodo.
        public void AnadirInicio(double nuevoDato)
        {
            Nodo nuevoNodo = new Nodo(nuevoDato);
            nuevoNodo.Next = head;
            head = nuevoNodo;
        }

        // AñadirFinal. Inserta un nuevo nodo al final de la lista. El parametro es el dato que almacena el nodo.
        public void AnadirFinal(double nuevoDato)
        {
            Nodo nuevoNodo = new Nodo(nuevoDato);
            if (EstaVacia)
                head = nuevoNodo;
            else
            {
                Nodo temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = nuevoNodo;
            }
        }

        // EliminarFinal. Remueve el ultimo nodo de la lista y retorna su dato.
        public double EliminarFinal()
        {
            double porRetornar;
            if (EstaVacia)
            {
                Console.WriteLine("Error, la lista esta vacia. Se retornara -1.");
                porRetornar = -1;
            }
            else
            {
                Nodo actual = head;
                Nodo anterior = head;

                while (actual.Next != null)
                {
                    anterior = actual;
                    actual = actual.Next;
                }

                // si es que hay un solo nodo en la lista
                if(actual == anterior)
                {
                    porRetornar = actual.Data;
                    head = null;
                }
                else
                {
                    porRetornar = actual.Data;
                    anterior.Next = null;
                }
            }
            return porRetornar;
        }

        // VerLista. Imprime por consola los datos que almacenan los nodos de la lista.
        public void VerLista()
        {
            if (EstaVacia)
                Console.WriteLine("Lista vacia.");
            else
            {
                Nodo temp = head;
                while(temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                }
            }
        }

        // EliminarLista. Remueve todos los nodos de la lista y retorna un arreglo con los datos que almacenaban los nodos
        public double[] EliminarLista()
        {
            double[] porRetornar = new double[0];

            int i = 0;
            while (head != null)
            {
                Array.Resize(ref porRetornar, i + 1);
                porRetornar[i] = EliminarFinal();
                i++;
            }
            return porRetornar;
        }
    }
}
