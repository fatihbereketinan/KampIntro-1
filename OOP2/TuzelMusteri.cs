using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Miras - Inheritance
    class TuzelMusteri:Musteri //Sen bir müşterisin
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }  //Bir nesnede bir değer nesneye ait değil gibi duruyorsa hata vardır!
    }
}
