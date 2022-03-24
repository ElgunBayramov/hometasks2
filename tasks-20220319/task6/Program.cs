using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib. Bu ededin evvel 20%-ni ,
            // sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap.
            Console.Write("eded daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 999 && a <= 9999)
            {
                double b = a * 20 * 1.0 / 100;
                Console.WriteLine($"{a} ededinin 20 faizi: {b}");
                double c = b * 10*1.0 / 100;
                Console.WriteLine($"{b} ededinin 10 faizi: {c}");

            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
        }
    }
}
