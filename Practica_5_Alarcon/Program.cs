using System;

namespace Practica_5_Alarcon
{
    class Program
    {
        static void Main(string[] args)
        {         
            // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx--------PROGRAMA 1-------xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            PriorityQueue queue = new PriorityQueue();
            string[] arrayStr;
            int[] arrayInt;
            string input;

            // the input is already specified to save time and show the way the input must be typed
            input = "1,4,9,46,23,1,4,7,25,55,100";
            arrayStr = input.Split(",");
            arrayInt = new int[arrayStr.Length];

            for (int i = 0; i < arrayInt.Length; i++)
                arrayInt[i] = Convert.ToInt32(arrayStr[i]);

            foreach (int number in arrayInt)
                queue.EnqueueAscending(number);

            Console.WriteLine("-----x-----PRUEBA PROGRAMA 1----x----\n");
            queue.PrintOddAndEven();
            Console.WriteLine();
            queue.Print();


            // xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx--------PROGRAMA 2-------xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            PriorityQueue queue1 = new PriorityQueue();
            PriorityQueue queue2 = new PriorityQueue();
            PriorityQueue queue3 = new PriorityQueue();

            // llenar con impares queue1
            for (int i = -1; i < 15; queue1.EnqueueAscending(i += 2)) ;
            // llenar con pares queue2
            for (int i = 0; i < 15; queue2.EnqueueAscending(i += 2)) ;

            Console.WriteLine("\n\n-----x-----PRUEBA PROGRAMA 2----x----\n");
            queue3.LinkQueues(queue1, queue2);
            queue1.Print();
            queue2.Print();
            queue3.Print();


        }
    }
}
