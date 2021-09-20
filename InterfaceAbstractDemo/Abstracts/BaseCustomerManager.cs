using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstracts
{
       abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Database to Saved " + customer.FirstName);
        }
    }
}
