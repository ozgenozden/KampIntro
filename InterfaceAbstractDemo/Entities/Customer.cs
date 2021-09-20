using InterfaceAbstractDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Entities
{
    class Customer:IEntity

    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
