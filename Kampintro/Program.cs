using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");   //Konsol ekranına bir sey yazmak icin

            //type safety - tip güvenliği demektir
            //Metinsel ifadeler çift tırnak içerisinde yazılmalıdır
            int ogrenciSayisi = 32000;
            double faizOrani = 3.1;
            string kategorietiketi = "Kategori";
            bool sistemegirisyapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 8.0;


            //if yazdıktan sonra 2 kere tab basılırsa otomatik parantezleri açar kapar

            //Sistem Giriş Şart Blokları Örneği
            if (sistemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");

            }


            //Dolar Durumu ile Şart Blokları Örneği
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");

            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");

            }

            else
            {
                Console.WriteLine("Değişmedi Oku");

            }


        }
    }
}
