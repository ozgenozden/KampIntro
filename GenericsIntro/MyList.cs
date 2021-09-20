using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        public T[] dizi;


        public MyList()
        {
           dizi = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = dizi;

            dizi = new T[dizi.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                dizi[i] = tempArray[i];
            }


            dizi[dizi.Length - 1] = item;
            
        }

        public T[] Items
        {
            get { return dizi; }
        }

        public T[] Itemss()
        {
            return dizi;
        }
    }
}
