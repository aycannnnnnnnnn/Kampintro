using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin";
            kurs1.KursAdi = "C#";
            kurs1.Oran = 90;



            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Aycan";
            kurs2.KursAdi = "PLC";
            kurs2.Oran = 60;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "X";
            kurs3.KursAdi = "AutoCad";
            kurs3.Oran = 80;

            //Console.WriteLine(kurs1.Egitmen + " " + kurs1.KursAdi + " " + kurs1.Oran);

            Kurs[] Kurslar = new Kurs[] { kurs1 , kurs2 , kurs3};

            foreach (var kurs in Kurslar)
            {
                Console.WriteLine(kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int Oran { get; set; }    
    }
}
