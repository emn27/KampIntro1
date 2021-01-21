using System;

namespace Dongular
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = " Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programaya baslangıc İcin Temel Kurs";
            string kurs3 = " Java ";
            string kurs4 = " Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            string[] kurslar = new string[] { " Yazılım Geliştirici Yetiştirme Kampı", "Programaya baslangıc İcin Temel Kurs"," Java ","Pyhton","c#" };
            


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa sonu - footer");


            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            

            
        }


    }
}
