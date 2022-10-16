using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary<T,U>
    {
        KeyValuePair<T,U>[]items;
        

        public MyDictionary()
        {
           items=new KeyValuePair<T, U>[0];
        }

        public void Add(T key,U value)
        {
           KeyValuePair<T,U>[]tempArray=items;//geçiçi dizi
           items=new KeyValuePair<T, U>[tempArray.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i]=tempArray[i];
            }
            items[items.Length-1]= new KeyValuePair<T,U>(key,value);

        }
        
        public void Show()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }
    }
}
