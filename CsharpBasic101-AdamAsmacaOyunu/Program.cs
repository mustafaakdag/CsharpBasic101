using System;

namespace CsharpBasic101_AdamAsmacaOyunu
{
    class Program
    {
        static void Main()
        {
            /*
             *Onceden tanimli kelimelerin bulundugu bir adam asmaca oyunu programlayiniz.
             * 6 hak uzerinden oynanacak
             * puanlandirma sorudaki harfSayisi*100=maksimum olacak sekilde hesaplanacak. puan her yanlis cevapta %15 azaltilacak
             * 2 cesit kullanici girisi olacak
             * 1.si harf harf tahmin
             * 2.si kelime tahmini
             *             
             */
            
            string menu2;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("***********************");
                Console.WriteLine(" 1- Adam Asmaca Oyunu \n 2- Kelime Tahmin Oyunu");
                Console.WriteLine("***********************");
                Console.WriteLine("***********************");

                Console.Write("Lutfen oyununuzu secin : ");
                int secim;
                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        do
                        {
                            int hak = 6, bilinen = 0;
                            string[] sorular = { "zeytinburnu", "kahramanmaras", "canakkale", "sanliurfa" };
                            Random rnd = new Random();
                            string seciliSoru = sorular[rnd.Next(sorular.Length)];
                            double puan = seciliSoru.Length * 100;
                            char[] ekran = new char[seciliSoru.Length];
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                ekran[i] = '_';
                            }

                            do
                            {
                                foreach (char ee in ekran)
                                {
                                    Console.Write(ee + " ");
                                }
                                string ozet = $"\n--> {seciliSoru.Length} harf. Puan : {puan} . Kalan Hakkiniz : {hak}";

                                Console.WriteLine(ozet);
                                Console.WriteLine("Tahmininizi giriniz.");
                                string tahmin = Console.ReadLine().ToLower();

                                if (tahmin.Length == 1)
                                {
                                    bool bildiMi = false, girildiMi = false;
                                    for (int k = 0; k < ekran.Length; k++)
                                    {
                                        if (ekran[k] == tahmin[0])
                                        {
                                            girildiMi = true;
                                            break;
                                        }
                                    }

                                    if (!girildiMi)
                                    {
                                        for (int i = 0; i < seciliSoru.Length; i++)
                                        {
                                            if (seciliSoru[i] == tahmin[0])
                                            {
                                                bildiMi = true;
                                                ekran[i] = tahmin[0];
                                                bilinen++;
                                            }
                                        }
                                    }

                                    if (!bildiMi)
                                    {
                                        hak--;
                                        puan *= 0.85;
                                    }
                                    //if (!bildiMi) hak--; puan *= 0.85;

                                }
                                else
                                {
                                    if (tahmin == seciliSoru)
                                    {
                                        break;
                                    }

                                    hak--;
                                    puan *= 0.85;
                                }
                            } while (hak > 0 && bilinen != seciliSoru.Length);

                            Console.WriteLine(hak > 0 ? "Tebrikler bildiniz" : "Belemediniz.");
                            Console.WriteLine("Tekrar oynamak icin x e bas.");

                            if (Console.ReadLine().ToLower() != "x")
                            {
                                break;
                            }


                        } while (true);
                    }
                    else if (secim == 2)
                    {
                        Console.Write("Yapim asamasinda daha sonra tekrar deneyin... ");
                    }
                    else
                    {
                        Console.Write("1 yada 2 arasinda secim yapin...");
                    }
                }
                catch (Exception)
                {
                    Console.Write("Lutfen 1 ile 2 arasinda numerik deger girin : ");
                    
                }

                

                Console.WriteLine("Menuye donmek icin 'm' e bas.");
                menu2 = Console.ReadLine();
            } while (menu2=="m");
            


            Console.ReadKey();
        }
    }
}
