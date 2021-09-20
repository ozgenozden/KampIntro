using ODEV5_5.Abstracts;
using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Adaptors
{
    class MernisCheckServiceManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
           return true;
        }
    }
}
