using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer({ DateOfBirth = new DateTime(1995, 7, 17), FirstName = "Yiğit", LastName = "Nebioğlu", NationalityId = "11111111111" });)
        }
    }
}
