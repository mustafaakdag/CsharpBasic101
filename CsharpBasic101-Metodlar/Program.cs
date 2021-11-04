using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verilen 2 sayiyi toplayan metod

            int toplam = Topla(3, 6);
            Deneme(4, 8);

            Console.WriteLine("Toplama islemi sonucu = " + toplam);

            int top1=MetodTest();
            int top2=MetodTest(23,23);
            int top3=MetodTest(12,23,34);
            Console.WriteLine("1.Toplama islemi sonucu = " + top1);
            Console.WriteLine("2.Toplama islemi sonucu = " + top2);
            Console.WriteLine("3.Toplama islemi sonucu = " + top3);

            toplam = Topla(2, 3, 4, 2, 1, 2, 1, 2, 1, 3, 2, 2, 3, 1);
            Console.WriteLine("Toplama islemi sonucu = " + toplam);

            string adSoyad = Ad() + " " + SoyAd();
            Console.WriteLine("Adi ve Soyadi = " + adSoyad);

            //Bir kenari 2 olan karenin alanini hesaplayin;
            int kenar1 = 2;
            int kenar2 = 4;
            float r = 5;

            Console.WriteLine("Bir kenari 2cm olan karenin alani = " +AlanHesapla(kenar1) +"cmkare");
            Console.WriteLine("dikdortgenin alani = " + AlanHesapla(kenar1,kenar2) + "cmkare");
            Console.WriteLine("Cemberin alani = " + AlanHesapla(r) + "cmkare");

            Console.ReadKey();
        }

        static int AlanHesapla(int a)
        {
            //kare alani hesaplamasi
            return a * a;
        }
        static int AlanHesapla(int a,int b)
        {
            //dikdortgen alani hesaplamasi
            return a * b;
        }
        static double AlanHesapla(float r, double pi=Math.PI)
        {
            //Cember alani hesaplamasi
            double rr = Convert.ToDouble(r * r);
            return rr*pi;
        }
        static string Ad()
        {
            string ad = "Onur";
            return ad;
        }
        static string SoyAd()
        {
            string soyad = "Agici";
            return soyad;
        }
        static void Deneme(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Denemeden Toplama islemi sonucu = " + toplam);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }
        static int MetodTest(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        static int MetodTest(int sayi1, int sayi2,int sayi3)
        {
            int toplam = sayi1 + sayi2+sayi3;
            return toplam;
        }
        static int MetodTest()
        {
            int toplam = 1 + 2;
            return toplam;
        }

        
    }
}
