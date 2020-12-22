using System;

namespace Pila_con_listas_enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            for (int i = 0; i < 6; stack.Push(i++)) ;
            Console.WriteLine("Count: {0}", stack.Count);

            Console.WriteLine("Print:");
            stack.Print();

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Pop: {0}", stack.Pop());

            Console.WriteLine("Count: {0}", stack.Count);
            Console.WriteLine("Print:");
            stack.Print();

            Console.WriteLine("In the array:");
            Object[] arr = stack.Delete();
            foreach (Object elem in arr)
                Console.WriteLine(elem);
        }
    }
}
