using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Kurt";
            musteri1.Tc = "9999999999";
            musteri1.Telefon = "0564646345";
            Musteri[] musteriler= new Musteri[]{musteri1};

            MusteriEkle(musteri1);
            MusteriListele(musteriler);
            Console.ReadLine();
        }

        public static void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Müşteri Eklendi");
            Console.WriteLine("--------------------");
        }

        public static void MusteriSil(int Id)
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public static void MusteriListele(Musteri[] musteriler)
        {
            foreach (var bilgi in musteriler)
            {
                Console.WriteLine("Adı: "+bilgi.Ad);
                Console.WriteLine("Soyadı: " + bilgi.Soyad);
                Console.WriteLine("Kimliği: " + bilgi.Tc);
                Console.WriteLine("Numarası: " + bilgi.Telefon);
            }
           
        }
    }
}
