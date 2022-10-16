using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refandoutwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            //int result=topla(number1, number2);
            //Console.WriteLine(result);
            //Console.WriteLine(number1);
            //Console.ReadLine();

            // int bir değer tip olduğu için sadece değeri gidiyor adresi ile birlikte değişmiyor.Bu yüzden number1'ın değeri 10 da kalıyor.
            //Ama biz number1 in başına ref number1 eklersek referans tipe dönüştürüyoruz.
            int result = topla(ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.ReadLine();
            //referans tiplerde adresi ile değiştiği için number1=10 cıkıyor.
            //ref ile out keywords leri aynı işlevi görür.
            //Aralarındaki fark  Ref de number 1 e değer vermek zorundayız main kısmında.
            //Out da main de number1 e değer vermesek de sıkıntı cıkarmadan programı yürütür ama metot da number1 de değer vermek zorundayız yoksa hata cıkıyor.
        }
        static int topla(ref int number1,int number2)
            
        {
            number1=30;
            return number1 + number2;
        }
    }
}
