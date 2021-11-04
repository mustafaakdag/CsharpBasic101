using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Donguler
{
    class Program
    {
        public static int[] sayilar = {10, 20, 25, 29, 34};
        public static string[] isimler = {"Onur", "Selin", "Tahir", "Orkun", "Sakir"};
        public static int SayiToplami = 0;
        public static int sayac = 0;
        public static bool kontrol = true;
        static void Main(string[] args)
        {
            //While Dongusu

            //DateTime suan =DateTime.Now;
            //int sayac = 0;

            //while (suan.Second<10)
            //{
            //    sayac++;
            //    Console.WriteLine(DateTime.Now);
            //    suan=DateTime.Now;
            //}

            Console.WriteLine("Menu");
            Console.WriteLine("*******************************");
            Console.WriteLine(" 1-: For Dongusu \n 2-: While Dongusu \n 3-: Do While Dongusu \n 4-: ForEach Dongusu");
            Console.WriteLine("*******************************");
            do
            {
                Console.Write("Seciminizi Giriniz:");
                int secim = 0; 

                try
                {
                    secim = int.Parse(Console.ReadLine());
                    //secim = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Numerik bir deger giriniz.");
                }


                switch (secim)
                {
                    case 1:
                        ForDongusu();
                        ToplamYaz();
                        break;
                    case 2:
                        WhileDongusu();
                        break;
                    case 3:
                        DoWhileDongusu();
                        ToplamYaz();
                        break;
                    case 4:
                        ForEachDongusu();
                        ToplamYaz();
                        break;
                }

                Console.Write("Devam etmek istiyorsaniz 'e' ye basin :");
                string devamMi = "";
                devamMi = Console.ReadLine();
                if (devamMi!="e")
                {
                    Console.Write("Gule Gule");
                    kontrol = false;
                    //break;
                }
            } while (kontrol==true);


            Console.ReadLine();
        }

        static void ForDongusu()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                SayiToplami += sayilar[i];
                //SayiToplami = SayiToplami + sayilar[i];
                Console.WriteLine((i+1) + ".Sayi = " + sayilar[i].ToString());
            }
        }

        static void WhileDongusu()
        {
            while (sayac<isimler.Length)
            {
                Console.WriteLine(isimler[sayac]);
                sayac++;
            }

            sayac = 0;
        }

        static void DoWhileDongusu()
        {
            do
            {
                SayiToplami += sayilar[sayac];
                Console.WriteLine((sayac + 1) + ".Sayi = " + sayilar[sayac]);
                sayac++;
                
            } while (sayac < sayilar.Length);

            sayac = 0;
        }

        static void ForEachDongusu()
        {
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
                SayiToplami += sayi;
            }
        }
        static void ToplamYaz()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Toplam = " + SayiToplami);
            Console.WriteLine("*******************************");
            SayiToplami = 0;
        }
    }
}
