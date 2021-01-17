using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Kurs1" , "Kurs2" , "Kurs3" , "Kurs4"};

            for (int i = 0; i < kurslar.Length; i++)  // i+=2 Yazılırsa iki iki artırılır
                                                      //kurslar.length kurslar değişkeninin uzunlugunu temsil eder
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string xkurs in kurslar)   //foreach Dizi temelli yapıları tek tek döndürmeye yarar 
            {
                Console.WriteLine(xkurs);
            }
        
        }
    }
}
