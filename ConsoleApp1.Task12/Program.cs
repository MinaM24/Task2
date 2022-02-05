using System;

namespace ConsoleApp1.Task12
{
    internal class Program
    {
        /* 12) 4 dene 6 reqemli eded verilib. 
         * Ededlerin hamisinin 10 faizini tap ve topla. 
         * Sonra hamisinin 15 faizini tap ve topla.
         * Sonra yekunda alinanlar iki cavabi vur biri birine. 
         * Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.*/

        static void Main(string[] args)
        {
            double a = 123456;
            double b = 234567;
            double c = 345678;
            double d = 456789;

            double a1;
            double b1;
            double c1;
            double d1;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000)
            {
                a1 = a * 0.10;
                b1 = b * 0.10;
                c1 = c * 0.10;
                d1 = d * 0.10;

                double e = a1 + b1 + c1 + d1;


                a1 = a * 0.15;
                b1 = b * 0.15;
                c1 = c * 0.15;
                d1 = d * 0.15;

                double f = a1 + b1 + c1+ d1;


                double g = e * f;
                g = g * 0.10;
                g = g * 0.11;

                Console.WriteLine(g);

            }
            else
            {
                Console.WriteLine("6 reqemli deyil");
            }

        }
    }
}
