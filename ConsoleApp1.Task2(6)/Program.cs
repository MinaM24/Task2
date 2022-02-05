using System;

namespace ConsoleApp1.Task2_6_
{
    internal class Program
    {
        /*5) 4 reqemli eded verilib. Bu ededin evvelin 4 reqemi,
         * axirina ise 44 ededini artir. Alinan cavabin 44 % tap.*/

        static void Main(string[] args)
        {
            int a = 1234;

            if (a >= 1000 && a < 10000)
            {
                a = 40000 + a;
                a = a * 100;
                a = a + 44;

                double b = a * 0.44;

                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
