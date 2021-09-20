using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Abstracts
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
