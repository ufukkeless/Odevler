using System;

namespace Ders3Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(new Musteri
            {
                Id = 1,
                Adi = "Ufuk",
                Soyadi = "Keleş",
                TcNo = "12345678901",
                Adresi = "asfgfdgdfasf"
            });
        }
    }
}
