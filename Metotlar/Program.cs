using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 10;
            string aciklama = "Kırmızı ";

            Urun urun1 = new Urun();
            urun1.Aciklama = "Kırmızı";
            urun1.Adi = "Elma";
            urun1.Fiyat = 10;

            Urun urun2 = new Urun();
            urun2.Aciklama = "Yesil";
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 20;

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine(x.Fiyat);
                Console.WriteLine("------------------");


            }

            Console.WriteLine("----------metotlar--------------");

            SepetManager a = new SepetManager();
            a.Ekle(urun1);

        }
    }
}
