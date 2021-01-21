using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety= tip güvenliği
            // do not repeat yourself = kendini tekrarlama 
            // değer tutucu, alias

            string kategoriEtiketi = " Kategoriler";
            int ögrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmişMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi  butonu");
            }
            

            


            

           

          


            if (sistemeGirişYapmişMı == true)
            {
                Console.WriteLine("Kullanıcı ayarlari butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            
           
            
            
          

           
            
             
            
            
            
            
            

            Console.WriteLine(kategoriEtiketi);
            
            
            
            










        }
    }
}
