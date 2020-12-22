using System;

namespace Cola_con_listas_enlazadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            for (int i = 0; i < 6; queue.Enqueue(i++)) ;
            Console.WriteLine("Count: {0}", queue.Count);

            Console.WriteLine("Print:");
            queue.Print();

            for (int i = 0; i < 3; i++)
                Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            Console.WriteLine("Count: {0}", queue.Count);
            Console.WriteLine("Print:");
            queue.Print();


            Console.WriteLine("fin");
        }
    }
}
