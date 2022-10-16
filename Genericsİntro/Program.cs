using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Çağatay");
            Console.WriteLine(myList.Lenght);

        }

        
    }
}
