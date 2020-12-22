using System;
using System.Collections.Generic;
using System.Text;

namespace Struct_Test1
{
    class Rational
    {
        public static void Main(string[] args)
        {
            Rationa a;
            Rationa b;
            Rationa c;

            // Inicialization
            a.num = 1;
            a.den = 2;
            b = new Rationa(3, 4);

            Console.Write("Rationals typed:\na = ");
            PrintRationa(a);
            Console.Write("\nb = ");
            PrintRationa(b);

            // Validating both rationals
            if (ValidateRationals(a) && ValidateRationals(b))
            {

                Console.WriteLine("\n\nOPERATIONS");
                // Addition
                c = Add(a, b);
                Console.Write("\na + b = ");
                PrintRationa(c);

                // Subtraction
                c = Sub(a, b);
                Console.Write("\na - b = ");
                PrintRationa(c);

                // Multiplication
                Console.Write("\na * b = ");
                c = Mult(a, b);
                PrintRationa(c);
            }
            else
                Console.WriteLine("\n\nFractions entered are invalid");
            


        }

        public struct Rationa
        {
            public int num;
            public int den;

            public Rationa(int x, int y)
            {
                num = x;
                den = y;
            }
        }

        // Validate Rationa
        public static bool ValidateRationals(Rationa a)
        {
            if (a.den != 0)
                return true;
            else
                return false;
        }

        // Rationa addition
        public static Rationa Add(Rationa a, Rationa b)
        {
            Rationa c;
            c.num = a.num * b.den + a.den * b.num;
            c.den = a.den * b.den;
            return c;
        }

        // Rationa subtraction
        public static Rationa Sub(Rationa a, Rationa b)
        {
            Rationa c;
            c.num = a.num * b.den - a.den * b.num;
            c.den = a.den * b.den;
            return c;
        }

        // Rationa multiplication
        public static Rationa Mult(Rationa a, Rationa b)
        {
            Rationa c;
            c.num = a.num * b.num;
            c.den = a.den * b.den;
            return c;
        }

        // Print Rationa
        public static void PrintRationa(Rationa a)
        {
            Console.Write($"{a.num}/{a.den}");
        }
    }
}
