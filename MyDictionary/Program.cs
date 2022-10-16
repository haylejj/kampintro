using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            MyDictionary<int,string> myDictionary= new MyDictionary<int,string>();
            myDictionary.Add(1, "bir");
            myDictionary.Add(2, "iki");
            myDictionary.Add(3, "üç");
            myDictionary.Add(4, "dort");
            myDictionary.Add(5, "beş");
            myDictionary.Add(6, "altı");
            myDictionary.Add(7, "yedi");
            myDictionary.Add(8, "sekiz");
            myDictionary.Add(9, "dokuz");

            myDictionary.Show();
            
        }
    }
}
