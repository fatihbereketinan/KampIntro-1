using InterfaceAbstractDemo2.Abstract;
using InterfaceAbstractDemo2.Concrete;
using System;

namespace InterfaceAbstractDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "11111111111"});
        }
    }
}
