using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaselogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();


            basvuruManager.BasvuruYap(new IhtiyacKrediManager(),databaselogger);
            basvuruManager.BasvuruYap(new KonutKrediManager(),fileLogger);

            List<IKrediManager> krediManagers = new List<IKrediManager>()
            {
                new TasitKrediManager(),
                new KonutKrediManager()
            };
            basvuruManager.KrediOnBilgilendirmesiYap(krediManagers);


        }
    }
}
