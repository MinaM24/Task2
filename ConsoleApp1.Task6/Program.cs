using System;

namespace ConsoleApp1.Task6
{
    internal class Program
    {
        /* 6) 4 reqemli eded verilib. Bu ededin evvel 20%-ni, 
         * sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.*/

        static void Main(string[] args)
        {
            int a = 1234;

            if (a >= 1000 && a < 10000)
            {
                double b = a * 0.20;
                double d = b * 0.10;
                double p = Math.Pow(d, 2);

                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
