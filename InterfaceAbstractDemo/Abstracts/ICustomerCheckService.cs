using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstracts
{
    interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
