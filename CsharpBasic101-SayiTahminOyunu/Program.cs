using System;

namespace CsharpBasic101_SayiTahminOyunu
{
    class Program
    {
        static void Main()
        {
            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1, 100), sayac = 0;
                Console.WriteLine("1-100 arasinda bir sayi tahmin edin...");
                do
                {
                    try
                    {
                        sayac++;
                        var tahmin = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                        if (tahmin < 1 || tahmin > 99)
                        {
                            throw new ArgumentException("Lutfen 1-100 arasinda giris yapiniz.");
                        }

                        if (rastgele < tahmin)
                        {
                            Console.WriteLine("Asagi");
                        }
                        else if (rastgele > tahmin)
                        {
                            Console.WriteLine("Yukari");
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler " + sayac + ". denemede bildiniz.");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);

                Console.WriteLine("Tekrar oynamak icin 'p' yaziniz.");
                string cevap = Console.ReadLine();
                if (cevap != null && cevap.ToLower() != "p") break; 
            } while (true);
            

            Console.ReadKey();
        }
    }
}
