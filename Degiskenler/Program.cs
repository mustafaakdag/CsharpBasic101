using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //PascalCase
            //camelCase  

            //isimlendirme kurallari

            //isimler rakam ile baslamaz ama icinde rakam bulundurabilir.
            //isimler ozel karakterler barindiramazlar '@,#,%,^ gibi' ancak '_' istisnadir.
            //Sistemde tanimli keywordleri degisken ismi olarak kullanamayiz.

            //Ayni Namespaces uzerinde tanimli bir degisken ismini tekrar tanimlayamiyoruz.

            //TAD => TipAdi Ad = Deger;

            //tamsayi tipleri

            byte dgByte = 255; // 0-255 arasi deger alir.
            sbyte dgSbyte = 127; // -128 - 127 arasi deger alir.
            short dgShort = 32767;//-32768 - 32767
            ushort dgUshort = 65535;//0 - 65535
            int dgIntMax = int.MaxValue;
            int dgIntMin = int.MinValue;
            uint dgUint = uint.MaxValue;
            long dgLongMax = long.MaxValue;
            long dgLongMin = long.MinValue;

            Console.WriteLine("Byte degiskeni : " + dgByte);
            Console.WriteLine("SByte degiskeni : " + dgSbyte);

            Console.WriteLine("Int max degiskeni : " + dgIntMax);
            Console.WriteLine("Int min degiskeni : " + dgIntMin);
            Console.WriteLine("UInt max degiskeni : " + dgUint);
            Console.WriteLine("Long max degiskeni : " + dgLongMax);
            Console.WriteLine("Long min degiskeni : " + dgLongMin);


            // Ondalikli Tipler

            float dgFloat = 3.14f;
            double dgDouble = 3.14d;
            decimal dgDecimal = 3.14m;
            Console.WriteLine("Float degiskeni : " + dgFloat);
            Console.WriteLine("Float degiskeni {0} {1}" ,dgFloat,dgShort);
            

            //Metinsel Ifadeler

            char dgChar = 'e';
            string dgString = "Selam";

            //Mantiksal Ifade

            bool dgBool = true;//false

            //Tarih Saat Ifadeleri

            DateTime suan=DateTime.Now;
            //suan = suan.Date;
            suan = suan.ToLocalTime();
            Console.WriteLine(suan);

            object dgObject = dgIntMax;
            dgObject = "dgIntMax";
            dgObject = 3.14f;

            Console.WriteLine(dgObject);

            var a = dgObject;
            
            //a = 3.14f;
            Console.WriteLine(a);

            //Tip Donusumleri

            //Iki cesit veri tipi var

            //Bu konunun okumalarini one drive uzerine gonder.

            // 1. Value Type
            int b = 3;
            string ss = "dfsf";

            // 2. Reference type
            //Meyve elma = new Meyve();

            int aa = 55;

            Console.ReadKey();
        }
    }
}
 