using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.Name="Çağatay";
            musteri1.Surname="Cingiz";
            musteri1.Id=1;
            musteri1.AvailableMoney=5000;

            Musteri musteri2= new Musteri();
            musteri2.Name="Ali";
            musteri2.Surname="Kahraman";
            musteri2.Id=2;
            musteri2.AvailableMoney=4120;

            Musteri[] musteriler = new Musteri[]{ musteri1, musteri2 };

            MusteriYonetimi musteriYonetimi= new MusteriYonetimi();

            musteriYonetimi.MusteriEkle(musteri1);

            musteriYonetimi.MusteriSil(musteri2 );

            musteriYonetimi.MusterileriSırala(musteriler);


        }
    }
}
