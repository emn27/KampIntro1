using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = " Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";

            // Kodlama. io

            TüzelMusteri musteri2 = new TüzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama. io";
            musteri2.VergiNo = "1234567890";

            // Gerçek Müsteri - Tüzel Müsteri
            //SOLİD = Sırf birbirine benziyor diye birbirin yerine kullanma anlamına gelir 


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TüzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
