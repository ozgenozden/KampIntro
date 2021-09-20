using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<string> test = new MyList<string>();
            test.Add("Özgen");
            test.Add("Özgür");

            
            foreach (var item in test.Items)
            {
                Console.WriteLine(item);
            }


           
          
            Console.WriteLine();
        }
    }
}
