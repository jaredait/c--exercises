using System;

namespace Simulador_red_social_CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user1 = new Usuario("A", "a");
            Usuario user2 = new Usuario("b", "a");
            Usuario user3 = new Usuario("c", "a");
            Usuario user4 = new Usuario("z", "a");
            Usuario user5 = new Usuario("e", "a");
            Usuario user6 = new Usuario("f", "a");
            Usuario user7 = new Usuario("g", "a");
            Usuario user8 = new Usuario("dd", "a");
            Usuario user9 = new Usuario("dAd", "a");
            Usuario user10 = new Usuario("ded", "a");




            Arbol arbol = new Arbol(user4);

            //arbol.AddNodo(user4);
            arbol.AddNodo(user3);
            arbol.AddNodo(user2);
            arbol.AddNodo(user1);
            arbol.AddNodo(user5);
            arbol.AddNodo(user6);
            arbol.AddNodo(user7);
            arbol.AddNodo(user8);
            arbol.AddNodo(user9);
            arbol.AddNodo(user10);




            arbol.Print();
            Console.WriteLine(arbol.Existe("z"));

        }
    }
}
