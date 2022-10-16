using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericsİntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor=Bir class new lendiğinde otomatik calışan bloğa denir.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T Item)
        {
            T[] tempArray = items;
            items=new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i]=tempArray[i];
            }
              

        }
        public int Lenght
        {
            get { return items.Length; }
        }
    }
}
