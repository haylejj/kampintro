﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void biseyyap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            
            Console.WriteLine("İhtiyaç kredisi odeme planı hesaplandı.");
        }
    }
}
