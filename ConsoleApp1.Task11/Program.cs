using System;

namespace ConsoleApp1.Task11
{
    internal class Program
    {
        /* 11) 4 dene 5 reqemli eded verilib. 
         * I ededin ustune III ededi gel. 
         * II ededin usutune IV ededi gel.
         * Sonra cavablari vur birbirine. 
         * Alinan neticeden III ededin 3%-ni cix.*/


        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;
            int c = 34567;
            int d = 45678;

            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d < 100000)
            {
                int e = a+c;
                int f = b+d;

                int g = e * f;
                double h = g - (c * 003);

                Console.WriteLine(h);

            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
        }
    }
}
