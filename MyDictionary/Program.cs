using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        { 
           MyDictionary<int,string> OğrenciAdi = new MyDictionary<int, string>();
            OğrenciAdi.Add("Aykut");
            Console.WriteLine(OğrenciAdi.Count);
        }
    }
}
