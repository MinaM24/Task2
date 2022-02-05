using System;

namespace ConsoleApp1.Task14
{
    internal class Program
    {
        /* 14) 6 dene 6 reqemli eded verilib. 
           * Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir 
           * ve bir eded al.I neticeden II neticeni cix. 
           * Alinan cavabin 10% tap. Neticenin uzerine V ve VI ededleri gel. 
           * Yekunda alinan cavabin 11% tap.*/

        static void Main(string[] args)
        {
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 456789;
            int e = 987654;
            int f = 654321;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000 && f >= 100000 && f < 1000000)
            {
                int g = a + b + c + d + e + f;
                int h = (a * 1000000) + c;

                double i = g - h;
                i = i * 0.10;
                i = e + f;
                i = i * 0.11;

           
                Console.WriteLine(i);


            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }


        }
    }
}
