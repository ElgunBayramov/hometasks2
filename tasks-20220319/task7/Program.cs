using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene 5 reqemli eded verilib. Bu ededleri toplayib.
            // Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap
            Console.Write("birinci ededi daxil et: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b=Convert.ToInt32(Console.ReadLine());
            if (a>9999 && a<=99999 && b>9999 && b <= 99999)
            {
                int c = a + b;
                Console.WriteLine("bu ededlerin cemi: "+ c);
                if (c >= 100000)
                {
                    double d = (5 * 1000000 + c) * 10 + 5;
                    Console.WriteLine(d);
                    double e = d * 5 * 1.0 / 100;
                    Console.WriteLine($"{d} ededinin 5 faizi: {e}");
                }
                else if (c < 100000)
                {
                    double d = (5 * 100000 + c) * 10 + 5;
                    Console.WriteLine(d);
                    double e = d * 5 * 1.0 / 100;
                    Console.WriteLine($"{d} ededinin 5 faizi: {e}");

                }
                else
                {
                    Console.WriteLine("sert duzgun deyil");
                    return;
                }
            }
            else
            {
                Console.WriteLine("ededler 5 reqemli deyil");
            }
        }
    }
}
