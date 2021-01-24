using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";                   **İsimler string dizisi'nin adresi değiştirildi.
            //Console.WriteLine(isimler[4]);          **O yüzden isimler[0] boş olarak geldi.
            //Console.WriteLine(isimler[0]);          **Dizi kaç elemanlıysa o kadar eleman tanımlanabilir.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);          
            Console.WriteLine(isimler2[2]);  
            Console.WriteLine(isimler2[3]);                          
            isimler2.Add("İlker");           //**Adres değişmedi ve diziye List komutu sayesinde dizi'ye yeni bir eleman ekleyebildik.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
