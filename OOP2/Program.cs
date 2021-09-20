using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Özgür";
            gercekMusteri.Soyadi = "Özden";
            gercekMusteri.TcNo = "12345678923";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "kodlama.io";
            tuzelMusteri.VergiNo = "9874661230";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(tuzelMusteri);





        }
    }
}
