using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Verificacion_Signos_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            string expresion = "(((";
            bool valid = true;

            expresion = expresion.Trim();
            Console.WriteLine(expresion);

            int i = 0;
            while (i < expresion.Length && valid)
            {
                if (expresion[i] == '(' || expresion[i] == '[' || expresion[i] == '{')
                    pila.Push(expresion[i]);
                if (expresion[i] == ')' || expresion[i] == ']' || expresion[i] == '}')
                {
                    if (pila.Count == 0)
                        break;  
                    switch (expresion[i])
                    {
                        case ')':
                            if ((char)pila.Pop() != '(')
                                valid = false;
                            break;
                        case ']':
                            if ((char)pila.Pop() != '[')
                                valid = false;
                            break;
                        case '}':
                            if ((char)pila.Pop() != '{')
                                valid = false;
                            break;
                    }
                }
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(valid);
            Console.WriteLine(pila);
            
            foreach(char element in pila)
            {
                Console.WriteLine(element);
            }
        }
    }
}
