using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ıhtiyacKrediManager= new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            KonutKrediManager konutKrediManager=new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //alttaki ile üstteki aynı sonucu verir.
            //interfaceler de o interfaci i impelemnte eden classın referans numarasını tutar.

            //IKrediManager ıhtiyacKrediManager2 = new IhtiyacKrediManager();
            //ıhtiyacKrediManager.Hesapla();

            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            BasvuruManager basvuruManager=new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager);

            List<IKrediManager> krediler=new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager,konutKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
