using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concretes;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdaptors());

            baseCustomerManager.Save(new Customer() {NationalityId="33940901312",FirstName="Özgen", LastName="Özden",DateOfBirth=new DateTime(1992,08,05)});
        }
    }
}
