using ODEV5_5.Abstracts;
using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Concretes
{
    class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı üye silindi.");
        }

        public void Save(Gamer gamer)
        {
            if(_customerCheckService.CheckIfRealPerson(gamer))
            Console.WriteLine(gamer.FirstName + " adlı üye kaydedildi.");
            else
            {
                throw new Exception("E devlette böyle bir kişi bulunmamaktadır.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı üye güncellendi.");
        }
    }
}
