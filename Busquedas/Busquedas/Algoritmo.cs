using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Busquedas
{
    class Algoritmo
    {
        // Busqueda secuencial
        // Devuelve el indice de la primera ocurrencia del elemento buscado, si no lo encuentra retorna -1.
        public static int Secuencial(int[] arreglo, int valor)
        {
            int indice = -1;
            for(int i = 0; i < arreglo.Length; i++)
            {
                if(arreglo[i] == valor)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }

        // Busqueda secuencial 2
        // Devuelve true si el valor buscado existe, false si no.
        public static bool Secuencial2(int[] arreglo, int valor)
        {
            bool existe = false;
            foreach(int elemento in arreglo)
            {
                if(elemento == valor)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        // Busqueda secuencial 3
        // Devuelve un arreglo que contiene el indice de las coincidencias
        public static int[] Secuencial3(int[] arreglo, int valor)
        {
            int index = 0;
            int[] indices = new int[arreglo.Length];
            for (int i = 0; i < arreglo.Length; i++)
                if (arreglo[i] == valor)
                    indices[index++] = i;   // Notar que el posincremento se ejecuta luego que el primer indice es almacenado y asi sucesivamente
            
            // Redimensionar el arreglo para que se ajuste a la cantidad de elementos relevantes
            Array.Resize(ref indices, index);
            Console.WriteLine(indices.Length);
            return indices;
        }
    }
}
