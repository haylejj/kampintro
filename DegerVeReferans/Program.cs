using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 5;
            int sayi2 = 8;
            sayi1 = sayi2;
            sayi2=30;
            Console.WriteLine(sayi1);
        }
    }
}
