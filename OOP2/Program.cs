using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id=1;
            musteri1.CustomerNumber="123456";
            musteri1.Name="Çağatay";
            musteri1.Surname="Cingiz";
            musteri1.TcNumber="5687491984";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id=2;
            musteri2.CustomerNumber="187455";
            musteri2.CompanyName="Cng";
            musteri2.TaxNumber="1234567890";

            // referans oldugunu gostermek icin
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager=new CustomerManager();
            customerManager.Add(musteri2);
        }
    }
}
