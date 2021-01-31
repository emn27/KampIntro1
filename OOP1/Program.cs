using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product();
            product2.Id = 2;
            product2.CategoryId = 5;
            product2.ProductName = "Kalem";
            product2.UnitPrice = 35;
            product2.UnitsInStock = 5;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            // Product product2 = new Product { Id = 2, CategoryId = 5,ProductName ="Kalem", UnitPrice =35, UnitsInStock = 5 }; bu şekildede yazılır.
            //PascalCase = kelimenin ilk harfi büyük yazılır.
            // camelCase = kelimenin ilk harfi küçük diğer kelimenin ilk harfi büyük yazılır. class anlamına gelir.
            // case sensitive = küçük büyük harf duyarlı demek.     
            // int, double, bool.... değer tip
            // diziler, class, abstract class, interface... referans tip
            // productManager.Topla2(3, 6);
            // int toplamaSonucu = productManager.Topla(3, 6);
            // Console.WriteLine(toplamaSonucu*2);



        }
    }
}
