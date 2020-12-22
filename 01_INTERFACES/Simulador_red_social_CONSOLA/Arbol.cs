using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_red_social_CONSOLA
{
    class Arbol
    {
        // Propiedades
        public Nodo Raiz { get; set; }

        // Constructores (sobrecargados)
        public Arbol(Usuario newUsuario)
        {
            Raiz = new Nodo(newUsuario);
        }
        public Arbol()
        {
            Raiz = null;
        }

        //  METODOS

        // Nombre: AgregarNodo
        // Proposito: inserta un nuevo nodo en el arbol de manera que los que se encuentran a la izquierda en cada subarbol son primeros alfabeticamente
        public void AddNodo(Usuario newUsuario)
        {
            Raiz = AddNodo(newUsuario, Raiz);
        }
        private Nodo AddNodo(Usuario newUsuario, Nodo temp)
        {
            // Caso base
            if (temp == null)
                temp = new Nodo(newUsuario);
            // Caso recursivo
            else
            {
                if (AFirstThanB(newUsuario.Username, temp.Dato.Username))
                    temp.HijoIzquierdo = AddNodo(newUsuario, temp.HijoIzquierdo);
                else
                    temp.HijoDerecho = AddNodo(newUsuario, temp.HijoDerecho);
            }
            return temp;
        }

        // PRINT. (overloaded) Prints the tree using recursion
        public void Print()
        {
            Print(Raiz, 4);
        }
        private void Print(Nodo p, int padding)
        {
            if (p != null)
            {
                if (p.HijoDerecho != null)
                    Print(p.HijoDerecho, padding + 4);

                if (padding > 0)
                    Console.Write(" ".PadLeft(padding));

                if (p.HijoDerecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.Dato.Username + "\n ");
                if (p.HijoIzquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.HijoIzquierdo, padding + 4);
                }
            }
        }
        
        // Nombre: Existe
        // Proposito: retorna true si es que el argumento coincide con un elemento en el arbol
        public bool Existe(string str)
        {
            return Existe(str.ToLower(), Raiz);
        }
        private bool Existe(string str, Nodo temp)
        {
            if (temp == null)
                return false;
            if (str == temp.Dato.Username)
                return true;

            if (AFirstThanB(str, temp.Dato.Username))
                return Existe(str, temp.HijoIzquierdo);
            else
                return Existe(str, temp.HijoDerecho);
        }

        // AFirstThanB. Returns true if the string a is first than the string b alphabetically
        static bool AFirstThanB(string a, string b)
        {
            // Base cases
            if (a.Length <= 0 || b.Length <= 0)
                return false;
            if (a[0] < b[0])
                return true;
            if (a[0] > b[0])
                return false;
            // Recursive cases
            return AFirstThanB(a[1..], b[1..]);
        }

    }
}
