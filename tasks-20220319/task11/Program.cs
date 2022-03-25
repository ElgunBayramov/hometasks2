using System;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene 5 reqemli eded verilib. Her I ededin ustune III ededi gel . II ededin usutune IV eeddi gel.
            // Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.
            Console.Write("birinci ededi daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu ededi daxil et: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("dorduncu ededi daxil et: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (a > 9999 && a <= 99999 && b > 9999 && b <= 99999 && c > 9999 && c <= 99999 && d > 9999 && d <= 99999)
            {
                double x = a + c;
                Console.WriteLine("birinci ededle ucuncu ededin cemi= "+x);
                double y= b + d;
                Console.WriteLine("ikinci ededle dorduncu ededin cemi= "+y);
                double z = x * y;
                Console.WriteLine($"{x} ededinin {y} ededine hasili= "+z);
                double n=z - (c * 3 * 1.0 / 100);
                Console.WriteLine($"{z} ededi ile {c} ededinin 3 faizinin ferqi= "+n);
            }
            else
            {
                Console.WriteLine("sert duzgun odenilmeyib");
            }
        }
    }
}
