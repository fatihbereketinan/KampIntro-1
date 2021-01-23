using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri İsim: " + customer.customerName + " " + "Müşteri Soyisim: " + customer.customerSurname + " " + "Müşteri ID: " + customer.customerId + " Kaydedildi!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri İsim: " + customer.customerName + " " + "Müşteri Soyisim: " + customer.customerSurname + " " + "Müşteri ID: " + customer.customerId + " Silindi!");
        }
        public void List(Customer[] CustomerList)
        {
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine("Müşteri İsim: " + customer.customerName + " " + "Müşteri Soyisim: " + customer.customerSurname + " " + "Müşteri ID: " + customer.customerId + " Listelendi");
            }
            
        }
    }
}
