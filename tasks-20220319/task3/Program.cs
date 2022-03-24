using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 reqemli eded verilib. Bu ededin evvel 18 % sonra ise 3 % tap.
            Console.Write("eded daxil edin: ");
            double a=Convert.ToDouble(Console.ReadLine());
            if(a>9999 && a <= 99999)
            {
                double b = a * 18 / 100;
                Console.WriteLine($"{a} ededinin 18 faizi: {b}");
                double c = a * 3 / 100;
                Console.WriteLine($"{a} ededinin 3 faizi: {c}");
            }
            else
            {
                Console.WriteLine("eded 5 reqemli deyil");
            }
        }
    }
}
