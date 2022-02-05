using System;

namespace ConsoleApp1.Task13
{
    internal class Program
    {
        /* 13) 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 
         * 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,
         * neticeleri vur bir birine.
         * Sonra 3 reqemli ededlerin 3% tap ,neticeleri topla. 
         * Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.*/

        static void Main(string[] args)
        {

            double a = 12345;
            double b = 23456;
            double c = 34567;
            double d = 456;
            double e = 678;


            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 100 && d < 1000 && e >= 100 && e < 1000)
            {
                a = a * 0.05;
                b = b * 0.05;
                c = c * 0.05;
                
                double f = a * b * c;

                d = d * 0.03;
                e = e * 0.03;

                double g = d + e;

                double h = (f * 0.10) + (g * 0.10);


                Console.WriteLine(h);

            }
            else
            {
                Console.WriteLine("5 ve 3 reqemli deyil");
            }
        }
    }
}
