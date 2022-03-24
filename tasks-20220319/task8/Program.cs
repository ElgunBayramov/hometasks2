using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene eded verilib. I eded 4 reqemli II eded 7 reqemlidir.
            // I ededin 4 % -ni tap.
            // Sonra II ededin 9 % ni tap.
            // Sonra Cavalari toplayib 10 % ni tap
            Console.Write("birinci ededi daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a>999 && a <= 9999 && b>999999 && b<=9999999)
            {
                double c = a * 4 * 1.0 / 100;
                Console.WriteLine($"{a} ededinin 4 faizi: {c}");
                double d = b * 9 * 1.0 / 100;
                Console.WriteLine($"{b} ededinin 9 faizi: {d}");
                double e = (c + d)*10*1.0/100;
                Console.WriteLine($"{c} ve {d} ededlerinin ceminin 10 faizi: {e}");
            }
            else
            {
                Console.WriteLine("sert duzgun deyil");
            }
         }
    }
}
