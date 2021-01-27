using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, ref number2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int Add(ref int number1, ref int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
     }
}
