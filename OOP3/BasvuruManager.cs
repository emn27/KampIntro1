using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();

            // Başvuran bilgilerini değerlendirme

            //KonutKrediManager konutKredi = new KonutKrediManager();
            //konutKredi.Hesapla();
            // eğer böyle yaparsak tüm kredileri konutkredileri üzerinden hesaplama yapacaktır.
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }

}
