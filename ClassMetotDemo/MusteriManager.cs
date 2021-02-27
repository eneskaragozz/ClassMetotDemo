using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Eklendi!");
            Console.WriteLine("Adı: " + musteri.Ad);
            Console.WriteLine("Soyadı: " + musteri.Soyad);
        }
        public void MusteriListele(Musteri[] musteriler) 
        {
            Console.WriteLine("Müşteriler Listeleniyor!");

            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " ");
            }

        }
        public void MusteriSil(Musteri musteri) 
        {
            Console.WriteLine("Kaydınızı sildik" );
            Console.WriteLine("Sayın : " + musteri.Ad + " " + musteri.Soyad);
        }

    }
}
