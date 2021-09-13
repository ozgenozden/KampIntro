using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

           // string[] degerler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";


             
            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------------------------");
            }


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product2);


        }
    }
}
