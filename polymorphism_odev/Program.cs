using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Elektronik elektronik = new Elektronik();
            elektronik.UrunAdi = URUNADİ.HpVictus;
            elektronik.Fiyat = 32000;
            elektronik.KdvHesapla();

            Gıda gıda = new Gıda();
            gıda.UrunAdi = URUNADİ.Çikolata;
            gıda.Fiyat = 15;
            gıda.KdvHesapla();

            Console.WriteLine($"{gıda.Fiyat+elektronik.Fiyat}");

            Console.ReadLine();

        }
    }
    public enum URUNADİ: byte
    {
        Çikolata=1,
        Süt,
        Yoğurt,
        Salça,
        Su,
        HpVictus,
        Mackbook,
        Asus
    }
}
