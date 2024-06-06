using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_odev
{
    internal class Urun
    {
        public URUNADİ UrunAdi { get; set; }
        public int Fiyat { get; set; }

        public virtual void KdvHesapla()
        {
            Console.WriteLine("Ürün Adı: {0} Ürün Fiyatı: {1}", UrunAdi, Fiyat);
        }

    }
}
