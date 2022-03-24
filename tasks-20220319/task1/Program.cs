using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 reqemli eded verilib.Bu ededin eveline 7 reqemini,
            // axirinada 8 reqemini artir. Example1: 333 = 73338
            Console.Write("eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a>999 && a <= 9999)
            {
               
               Console.WriteLine($"{7}{a}{8}");
            }
            else
            {
                Console.WriteLine("eded 4 reqemli deyil");
            }
        }
    }
}
