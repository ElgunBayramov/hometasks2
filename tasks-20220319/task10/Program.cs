using System;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 4 reqemli eded verilib. I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
            // Neticeleri bir birinden cix. Alinan cavabin ustune III ededin 7 % faizini gel
            Console.Write("birinci ededi daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu ededi daxil et: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a > 999 && a <= 9999 && b > 999 && b <= 9999 && c > 999 && c <= 9999)
            {
                double d = a * 1*1.0 / 100;
                Console.WriteLine($"{a} ededinin 1 faizi: {d}");
                double e= b * 2*1.0 / 100;
                Console.WriteLine($"{b} ededinin 2 faizi: {e}");
                double f = c * 3*1.0 / 100;
                Console.WriteLine($"{c} ededinin 3 faizi: {f}");
                double y = d - e - f;
                Console.WriteLine("bu ededlerin ferqi~="+ Math.Round(y));
                double z = y + (f * 7 * 1.0 / 100);
                Console.WriteLine($"bu ededlerin ferqi ile {f} ededinin 7 faizinin cemi~= "+ Math.Round(z));

            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}
