using System;

namespace ConsoleApp1.Task2_3_
{
    internal class Program
    {
        /*3) 5 reqemli eded verilib. Bu ededin evvel 18 % 
         * sonra ise 3 % tap*/

        static void Main(string[] args)
        {
            int a = 12345;

            if (a >= 10000 && a < 100000)
            {
                double b = a * 0.18;
                Console.WriteLine(b);

                double c = a * 0.03;
                Console.WriteLine(c);
                

            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }
        }
    }
}
