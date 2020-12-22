using System;

namespace Practica_7_Alarcon
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();

            for (int i = -1; i < 5; miLista.AnadirInicio(i += 2)) ;
            Console.WriteLine("Contenido:");
            miLista.VerLista();

            for (int i = 0; i < 5; miLista.AnadirFinal(i += 2)) ;
            Console.WriteLine("Contenido:");
            miLista.VerLista();
            /*
            Console.WriteLine("Remover: {0}", miLista.EliminarFinal());
            Console.WriteLine("Remover: {0}", miLista.EliminarFinal());
            Console.WriteLine("Remover: {0}", miLista.EliminarFinal());
            Console.WriteLine("Remover: {0}", miLista.EliminarFinal());
            */
            Console.WriteLine("En el arreglo:");
            double[] miArreglo = miLista.EliminarLista();
            foreach (double num in miArreglo)
                Console.WriteLine(num);
            
            Console.WriteLine("Contenido:");
            miLista.VerLista();

            Console.WriteLine("fin");
        }
    }
}
