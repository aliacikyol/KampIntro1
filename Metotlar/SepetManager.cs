using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun) //parametre
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string urunAciklama, double urunFiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + "Ürün Adı: " + urunAdi + " " +  "Açıklama: " + urunAciklama + " " + "Fiyatı: " + urunFiyat + " " +  "Adedi: " + stokAdedi);
        }
    }
}
