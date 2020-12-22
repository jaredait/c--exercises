using System;
using System.Collections.Generic;
using System.Text;

namespace Postfix_to_expression_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            string infija;
            string postfija;

            Console.WriteLine("Ingresa la expresion infija:");
            infija = Console.ReadLine();

            postfija = Conversion.APostfija(infija);
            Console.WriteLine(postfija);
            Console.WriteLine("Arbol:\n\n");

            Tree tree = new Tree();
            tree.SetNode(postfija);

            tree.Print();
            Console.WriteLine();
            tree.PrintPostfix();
            tree.PrintPrefix();
            tree.PrintInfix();
        }

        
    }
}
