using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib.
            // Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir.
            // Alinan cavabin 44 % tap.
            Console.WriteLine("eded daxil et: ");
            int a=Convert.ToInt32(Console.ReadLine());
                if(a>999 && a <= 9999)
            {
                int b = (4 * 10000 + a) * 100 + 44;
                Console.WriteLine(b);
                double c = b * 44*1.0 / 100;
                Console.WriteLine($"{b} ededinin 44 faizi: {c}");
            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
        }
    }
}
