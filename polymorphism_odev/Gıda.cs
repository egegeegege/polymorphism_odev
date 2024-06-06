using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_odev
{
    internal class Gıda : Urun
    {
        public override void KdvHesapla()
        {
            Console.WriteLine("Ürün Adı: {0} Ürün Fiyatı: {1}", UrunAdi, Fiyat);
        }
    }
}
