using System;

namespace ConsoleApp1.Task7
{
    internal class Program
    {
        /*7) 2 dene 5 reqemli eded verilib. Bu ededleri toplayib. 
         * Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap*/

        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;

            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000) 
            {
                int c = a + b;
                c = 500000 + c;
                c = (c * 10) +5;

                double d = c * 0.05;
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("5 reqemli deyil");
            }


        }
    }
}
