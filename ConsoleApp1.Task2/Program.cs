using System;

namespace ConsoleApp1.Task2
{
    internal class Program
    {
        /* 1) 4 reqemli eded verilib. Bu ededin eveline 7 reqemini, 
         * axirinada 8 reqemini artir. Example1: 3333= 73338*/


        static void Main(string[] args)
        {
            int a = 1234;

            if (a >= 1000 && a < 10000)
            {
                a = 70000 + a;

                a = a * 10;
                a = a + 8;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }

    }

}
