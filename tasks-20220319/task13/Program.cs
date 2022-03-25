using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
 // 5 dene eded verilib. Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
 // Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.
            Console.Write("birinci eded: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci eded: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu eded: ");
            int c=Convert.ToInt32(Console.ReadLine());
            Console.Write("dorduncu eded: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("besinci eded: ");
            int e = Convert.ToInt32(Console.ReadLine());
            if(a>9999 && a<=99999 && b > 9999 && b <= 99999 && c > 9999 && c <= 99999 && d>99 && d<=999 && e>99 && e <= 999){
                double x = a * 5 * 1.0 / 100;
                Console.WriteLine($"{a} ededinin 5 faizi: {x}");
                double y = b * 5 * 1.0 / 100;
                Console.WriteLine($"{b} ededinin 5 faizi: {y}");
                double z = c * 5 * 1.0 / 100;
                Console.WriteLine($"{c} ededinin 5 faizi: {z}");
                double w = x * y * z;
                Console.WriteLine($"{x}*{y}*{z}={w}");
                double m = d * 3 * 1.0 / 100;
                Console.WriteLine($"{d} ededinin 3 faizi: {m}");
                double n = e * 3 * 1.0 / 100;
                Console.WriteLine($"{e} ededinin 3 faizi: {n}");
                double l = m + n;
                Console.WriteLine($"{m}+{n}={l}");
                double p=(w*10*1.0/100)+(l*10*1.0/100);
                Console.WriteLine($"{w} ededinin 10 faizi ile {l} ededinin 10 faizinin cemi: {p}");
            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}
