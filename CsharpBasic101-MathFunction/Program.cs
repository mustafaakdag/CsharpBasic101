using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //sqrt fonksiyonu
            double a = -0.04d;
            int b = 64;
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Sqrt(b));

            //Ceiling metodu

            Console.WriteLine(Math.Ceiling(2.12));

            //Round metodu

            Console.WriteLine(Math.Round(2.12));

            //pow fonksiyonu

            Console.WriteLine(Math.Pow(2,2));

            //Abs fonksiyonu

            Console.WriteLine(Math.Abs(a));

            Console.ReadKey();
        }
    }
}
