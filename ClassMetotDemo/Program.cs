using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Yılmaz";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Öztürk";

            int i;
            Console.WriteLine("Bir işlem seçiniz.");
            Console.WriteLine("1-Müşteri Ekleme");
            Console.WriteLine("2-Müşteri Silme");
            

            i = Convert.ToInt16(Console.ReadLine());
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            if (i == 1)
            {
                musteriManager.MusteriEkle(musteri1);
                musteriManager.MusteriEkle(musteri2);
            }
            else if (i == 2)
            {
                musteriManager.MusteriListele(musteriler);
            }
            else if (i == 3)
            {
                musteriManager.MusteriSil(musteri1);
                musteriManager.MusteriSil(musteri2);
            }

        }
    }
}
