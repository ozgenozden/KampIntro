using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");

            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;

            foreach (int Anahtar in AnahtarListesi)
                Console.WriteLine(Anahtar);

            MyDictionary<int, string> test = new MyDictionary<int, string>();
            test.Add(1, "Özgür");
            test.Add(2, "Özgen");

            Console.WriteLine(test.ContainsKey(1));

        }
    }
}


