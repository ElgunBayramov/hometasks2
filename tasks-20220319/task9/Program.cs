using System;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 6 reqemli eded verilib. Her birinin 10 faizini tapib neticeleri topla. Alinan cavabin 10% tap.
            Console.Write("birinci ededi daxil et: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci ededi daxil et: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("ucuncu ededi daxil et: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a>99999 && a<=999999 && b>99999 && b<=999999 && c>99999 && c <= 999999){
                double d = (a + b + c) * 10 * 1.0 / 100;
                Console.WriteLine(d);
                double e = d * 10 * 1.0 / 100;
                Console.WriteLine($"{d} ededinin 10 faizi: {e}");
            }
            else
            {
                Console.WriteLine("sert duzgun deyil");
            }
        }
    }
}
