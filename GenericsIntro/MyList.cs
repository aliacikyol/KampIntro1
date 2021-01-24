using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // 0 elemanlı bir dizi oluşturuldu.
    class MyList<T>
    {
        T[] items;
        //Constructor
        public MyList() 
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //Referans kaybolmasın diye geçici olarak başka diziye tanımlandık.
            items = new T[items.Length+1];//Dizi'nin eleman sayısı 1 arttırıldı.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
            items[items.Length - 1] = item;
        }
    }
}
