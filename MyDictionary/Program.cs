using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();
            myDict.Add(1, "Yiğit");
            myDict.Add(2, "Metin");
            myDict.Add(3, "Nuray");
            myDict.Add(4, "Cemile");

            myDict.ListAll();

        }
    }
}
