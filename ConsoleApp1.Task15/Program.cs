using System;

namespace ConsoleApp1.Task15
{
    internal class Program
    {
        /* 15)* 7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
         * 3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
         * Sonra neticenin axirina 7 reqemini artir. Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
         * Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
         * Sonra alinan cavabin ustune gel 6 reqemli ededi.
         * Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
         * Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
         * Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.*/


        static void Main(string[] args)
        {
            int a = 123;
            int b = 234;
            int c = 3456;
            int d = 4567;
            int e = 98765;
            int f = 65431;
            int g = 123456;

            if (a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 1000 && c < 10000 && d >= 1000 && d < 10000 && e >= 10000 && e < 100000 && f >= 10000 && f < 100000 && g >= 100000 && g < 1000000)
            {
                int h = a + b;
                int i = c * f;
                int j = h + i;
                int k = (j * 10) + 7;
                
                k = k + (e + f);

                int l = ((a * b) * 10) + 1;

                k = k - l;
                k = k + g;
                k = k - (a + b + c + d);

                double m = k * 0.018;
                m = m * 0.03;
                m = m * 0.01;
                m = m + (e + f);

                Console.WriteLine(m);

            }
            else
            {
                Console.WriteLine("2,3,4 ve ya 5 reqemli deyil");
            }






        }
    }
}
