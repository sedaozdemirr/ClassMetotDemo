using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0010;
            musteri1.Adi = "Seda";
            musteri1.Soyadi = "Özdemir";
            musteri1.Bakiye = 200.000;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 0011;
            musteri2.Adi = "Eda";
            musteri2.Soyadi = "Özdemir";
            musteri2.Bakiye = 800.000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0012;
            musteri3.Adi = "Sevgi";
            musteri3.Soyadi = "Özdemir";
            musteri3.Bakiye = 450.000;
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteriler : ");
                Console.WriteLine("Müşteri ID : " + musteri.Id);
                Console.WriteLine("Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("Müşteri Soyadı : " + musteri.Soyadi);
                Console.WriteLine("Müşteri Bakiyesi : " + musteri.Bakiye);
            }
            Console.WriteLine("------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Add(musteri3);

            musteriManager.Del(musteri3);



        }
    }
}
