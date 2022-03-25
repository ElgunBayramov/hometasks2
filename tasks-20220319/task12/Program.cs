using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 6 reqemli eded verilib. Ededlerin hamisinin 10 faizini tap ve topla. Sonra hamisinin 15 faizini tap ve topla.
            // Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10 % tap sonra ise hemin cavabin 11 % tap.
            Console.Write("birinci ededi daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu ededi daxil et: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("dorduncu ededi daxil et: ");
            int d = Convert.ToInt32(Console.ReadLine());
            if(a>99999 && a<=999999 && b > 99999 && b <= 999999 && c > 99999 && c <= 999999 && d > 99999 && d <= 999999)
            {
                double x=(a*10*1.0/100)+(b*10*1.0/100)+(c*10*1.0/100)+(d*10*1.0/100);
                Console.WriteLine("her bir ededin 10 faizinin cemi= "+x);
                double y=(a*15*1.0/100)+(b*15*1.0/100)+(c*15*1.0/100)+(d*15*1.0/100);
                Console.WriteLine("her bir ededin 15 faizinin cemi= "+y);
                double z = x * y;
                Console.WriteLine($"{x}*{y}={z}");
                double m = z * 10 * 1.0 / 100;
                Console.WriteLine($"{z} ededinin 10 faizi={m}");
                double n=m * 11 * 1.0 / 100;
                Console.WriteLine($"{m} ededinin 11 faizi={n}");
            }

        }
    }
}
