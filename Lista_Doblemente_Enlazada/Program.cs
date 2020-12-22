using System;

namespace Lista_Doblemente_Enlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            /*
            list.InsertEnd('1');
            list.InsertEnd('2');
            list.InsertEnd('3');
            list.InsertEnd('4');
            list.InsertEnd('5');
            list.InsertEnd('6');
            */

            Console.WriteLine("Count: {0}", list.count);

            Console.WriteLine("PrintEtoB:");
            list.PrintEtoB();
            
            Console.WriteLine("PrintBtoE:");
            list.PrintBtoE();

            Console.WriteLine("RemoveBeg: {0}", list.RemoveBeg());
            Console.WriteLine("PrintBtoE:");
            list.PrintBtoE();
            Console.WriteLine("RemoveEnd: {0}", list.RemoveEnd());
            Console.WriteLine("PrintBtoE:");
            list.PrintBtoE();

            Console.WriteLine("Fin");
        }
    }
}
