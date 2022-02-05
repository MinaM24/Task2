using System;

namespace ConsoleApp1.Task2_4_
{
    internal class Program
    {
        /*4) 3 reqemli eded verilib. Bu ededin axirina 7 artir. 
         * Sonra cavabin 7% tap;*/

        static void Main(string[] args)
        {
            int a = 123;

            if (a >= 100 && a < 1000)
            {
                a = a * 10;
                a = a + 7;

                double b = a * 0.07;

                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }

        }
    }
}
