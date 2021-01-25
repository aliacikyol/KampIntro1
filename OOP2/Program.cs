using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCostumer musteri1 = new IndividualCostumer();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "12345678910";

            CoorporateCostumer musteri2 = new CoorporateCostumer();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new IndividualCostumer();
            Musteri musteri4 = new CoorporateCostumer();



        }
    }
}
