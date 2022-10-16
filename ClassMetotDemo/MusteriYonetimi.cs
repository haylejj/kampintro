using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriYonetimi
    {
        public  void MusteriEkle(Musteri musteri )
        {
            Console.WriteLine("Müsteri Başarıyla eklendi. Adı:{0}--Soyadı:{1}--Id:{2}--Mevcut Parası:{3}",musteri.Name,musteri.Surname,musteri.Id,musteri.AvailableMoney);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Başarıyla Silindi!!. Adı:{0}--Soyadı:{1}--Id:{2}--Geçmiş Parası:{3}", musteri.Name, musteri.Surname, musteri.Id, musteri.AvailableMoney);
        }

        public void MusterileriSırala(Musteri[] Musteriler)
        {
            foreach (var item in Musteriler)
            {
                Console.WriteLine("Adı:{0}--Soyadı:{1}--Id:{2}--Mevcut Parası:{3}",item.Name,item.Surname,item.Id,item.AvailableMoney);
            }
        }
    }
}
