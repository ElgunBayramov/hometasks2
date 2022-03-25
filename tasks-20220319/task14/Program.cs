using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 dene 6 reqemli eded verilib. Evvel hamisini topla . Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            // I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.
            Console.Write("birinci eded: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci eded: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu eded: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("dorduncu eded: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("besinci eded: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("altinci eded: ");
            int f = Convert.ToInt32(Console.ReadLine());
            if(a > 99999 && a <= 999999 && b > 99999 && b <= 999999 && c > 99999 && c <= 999999 && d > 99999 && d <= 999999 && e > 99999 && e <= 999999 && f > 99999 && f <= 999999)
            {
                double x = a + b + c + d + e + f;
                Console.WriteLine($"{a}+{b}+{c}+{d}+{e}+{f}={x}");
                double y = double.Parse(a.ToString() + c.ToString());
                Console.WriteLine(y);
                double z = x - y;
                Console.WriteLine($"{x}-{y}={z}");
                double m=z*10 * 1.0 / 100;
                Console.WriteLine($"{z} ededinin 10 faizi= {m}");
                double n = m + e + f;
                Console.WriteLine($"{m}+{e}+{f}={n}");
                double l = n * 11 * 1.0 / 100;
                Console.WriteLine($"{n} ededinin 11 faizi= {l}");

            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}
