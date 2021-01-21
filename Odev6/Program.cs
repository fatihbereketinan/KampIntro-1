using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "İlk Ürün";
            urun1.UrunFiyati = 10;
            urun1.UrunSatisAdet = 100;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "İkinci Ürün";
            urun2.UrunFiyati = 20;
            urun2.UrunSatisAdet = 200;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Üçüncü Ürün";
            urun3.UrunFiyati = 30;
            urun3.UrunSatisAdet = 300;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            //For Döngüsü ile Yazdırma
            Console.WriteLine("For Döngüsü:");
            Console.WriteLine("**********");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün İsmi: " + urunler[i].UrunAdi + " / Ürün Fiyat: " + urunler[i].UrunFiyati + " / Ürün Satış Adeti: " + urunler[i].UrunSatisAdet);
            }
            Console.WriteLine(" ");
            //Foreach Döngüsü ile Yazdırma
            Console.WriteLine("Foreach Döngüsü:");
            Console.WriteLine("**********");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün İsmi: " + urun.UrunAdi + " / Ürün Fiyat: " + urun.UrunFiyati + " / Ürün Satış Adeti: " + urun.UrunSatisAdet);
            }
            Console.WriteLine(" ");
            //While Döngüsü ile Yazdırma
            Console.WriteLine("While Döngüsü:");
            Console.WriteLine("**********");
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine("Ürün İsmi: " + urunler[a].UrunAdi + " / Ürün Fiyat: " + urunler[a].UrunFiyati + " / Ürün Satış Adeti: " + urunler[a].UrunSatisAdet);
                a++;
            }
        }
    }
}
    class Urun
    {
    public string UrunAdi { get; set; }
    public int UrunFiyati { get; set; }
    public int UrunSatisAdet { get; set; }
}