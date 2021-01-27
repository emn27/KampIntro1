using System;

namespace ConsoleApp2
{
    using System;

    class Program
    {

        static void Main()
        {

            string[] kisiler = { "Emine", "Zehra", "Mehtap", "Gül" };
            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }
            Duzenle(kisiler);
            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }
        
        static void Duzenle(string[] kisiler)
        {
            for (int i = 0, kisiSayisi = kisiler.Length; i < kisiSayisi; i++)
            {
                kisiler[i] = "Emine";
            }
   

            int sayimiz = 3;
            Console.WriteLine("Başlangıç değeri: {0}", sayimiz);
            Kare(sayimiz);
            Console.WriteLine("Kare() sonrası: {0}", sayimiz);
            Kare2(ref sayimiz);
            Console.WriteLine("Kare2() sonrası: {0}", sayimiz);
        }

        static void Kare(int sayi)
        {
            sayi = sayi * sayi;
        }

        static void Kare2(ref int sayi)
        {
            sayi = sayi * sayi;
        }
            {

                int sayimizOut;
                DegistirOut(out sayimizOut);
                Console.WriteLine(sayimizOut);

                int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
                DegistirRef(ref sayimizRef);
                Console.WriteLine(sayimizRef);
            }

        static void DegistirRef(ref int sayiRef)
            {
                sayiRef = 1234;
            }

        static void DegistirOut(out int sayiOut)
            {
                sayiOut = 1234;

            string girilenSayi = "1453";
            int sayimiz;

            bool sonuc = int.TryParse(girilenSayi, out sayimiz);

            if (sonuc)
            {
                Console.WriteLine("Dönüşüm başarılı.");
                Console.WriteLine("Sayı: {0}", sayimiz);
            }
            else
            {
                Console.WriteLine("Dönüşüm başarısız.");
            }
        }
    }







}







}
