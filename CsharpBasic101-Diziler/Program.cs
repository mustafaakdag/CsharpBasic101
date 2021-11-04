using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //Console.ForegroundColor = ConsoleColor.Gray;
            //Array 

            int[] sayilar = new int[5];
            sayilar[0] = 2;
            sayilar[1] = 10;
            sayilar[2] = 8;
            sayilar[3] = 55;
            sayilar[4] = 23;

            int[] numbers = new int[5] {3, 5, 9, 43, 28};

            Console.WriteLine($"Eleman sayisi : {numbers.Length}");
            Console.WriteLine($"Dizinin ortalmasi : {numbers.Average()}");
            Console.WriteLine($"Dizinin ilk elemani : {numbers.First()}");
            Console.WriteLine($"Dizinin son elemani : {numbers.Last()}");
            Console.WriteLine($"Dizinin en buyuk elemani : {numbers.Max()}");
            Console.WriteLine($"Dizinin en kucuk elemani : {numbers.Min()}");
            Console.WriteLine($"Dizinin elemanlari toplami : {numbers.Sum()}");
            Console.WriteLine($"9 Dizinin kacinci elemani : {Array.IndexOf(numbers,9)}");


            var rnd = new Random();
            //var rastgeleSayi = rnd.Next(7, 24);


            for (int i = 0; i < 5; i++)
            {
                var rastgeleSayi = rnd.Next(7, 24);
                Console.WriteLine(rastgeleSayi); 
            }

            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Sali";
            gunler[2] = "Carsamba";
            gunler[3] = "Persembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            //Array.Clear(gunler,2,3);
            Array.Sort(gunler);
            Array.Reverse(gunler);

            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine(gunler[i]); 
            }

            char[] array = new char[5];
            array[0] = 's';
            array[1] = 'e';
            array[2] = 'l';
            array[3] = 'a';
            array[4] = 'm';

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            Array.Resize(ref array,8);
            array[5] = 'l';
            array[6] = 'a';
            array[7] = 'r';
            //array[8] = '.'; outofrange hatasi firlatir
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.ReadKey();
        }
    }
}
