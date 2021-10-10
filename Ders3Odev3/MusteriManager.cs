using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3Odev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteriler listesi");
        }
    }
}
