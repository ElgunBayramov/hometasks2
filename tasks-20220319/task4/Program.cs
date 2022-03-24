using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib. Bu ededin axirina 7 artir.
            // Sonra cavabin 7% tap;
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = 7;
            if(a>99 && a <= 999)
            {
                double c = a * 10 + b;
                Console.WriteLine(c);
                double d = c * 7 / 100;
                Console.WriteLine($"{c} ededinin 7 faizi: {d}");
             }
            else
            {
                Console.WriteLine("eded 3 reqemli deyil");
            }
        }
    }
}
