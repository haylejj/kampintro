using System;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1=new Urun();
            urun1.Id=1;
            urun1.Name="elma";
            urun1.Price=15;
            urun1.explantation="Amasya Elması";

            Urun urun2=new Urun();
            urun2.Id=2;
            urun2.Name="Karpuz";
            urun2.Price=25;
            urun2.explantation="Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.explantation);
                Console.WriteLine("-----------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
