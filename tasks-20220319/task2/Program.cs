using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 reqemli eded verilib.
            // Bu ededin axirina hemin ededdin ozunu yapishdir. example: 333= 333333;
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a>99 && a <= 999)
            {
                Console.WriteLine($"{a}{a}");
            }
            else
            {
                Console.WriteLine("eded 3 reqemli deyil");
            }
        }
    }
}
