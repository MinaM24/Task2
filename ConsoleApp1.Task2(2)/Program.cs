using System;

namespace ConsoleApp1.Task2_2_
{
    internal class Program
    {
        /*2) 3 reqemli eded verilib. Bu ededin axirina hemin ededdin 
             * ozunu yapishdir. example: 333= 333333;*/

        static void Main(string[] args)
        {
            int a = 123;

            if (a >= 100 && a < 1000)
            {
                int b = a*1000;
                b = b + a;

                Console.WriteLine(b);

                
            }
            else
            {
                Console.WriteLine("3 reqemli deyil");
            }

        }
    }
}
