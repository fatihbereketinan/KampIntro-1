using System;

namespace Methods_Video21
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Add2(2,49);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2) //Parametre - Döndürülen veri tipini staticten sonra yaz
        {
            var result = number1 + number2;
            return result;
        }
    }
}
