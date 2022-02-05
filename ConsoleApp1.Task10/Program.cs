using System;

namespace ConsoleApp1.Task10
{
    internal class Program
    {
        /* 10) 3 dene 4 reqemli eded verilib. 
         * I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
         * Neticeleri bir birinden cix. 
         * Alinan cavabin ustune III ededin 7% faizini gel*/

        static void Main(string[] args)
        {
            int a = 1234;
            int b = 2345;
            int c = 3456;


            if (a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000)
            {
                double d = a * 0.01;
                double e = b * 0.02;
                double f = c * 0.03;

                double g = d - e - f; 
                g = g + (c * 0.07);

                Console.WriteLine(g);

            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
           
        }
    }
}
