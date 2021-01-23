using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.customerId = 00001;
            customer1.customerName = "Yiğit";
            customer1.customerSurname = "Nebioğlu";

            Customer customer2 = new Customer();
            customer2.customerId = 00002;
            customer2.customerName = "Tarık";
            customer2.customerSurname = "Bozyiğit";

            Customer customer3 = new Customer();
            customer3.customerId = 00003;
            customer3.customerName = "Metin";
            customer3.customerSurname = "İşgüzar";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);

            Console.WriteLine("*****MÜŞTERİ LİSTESİ*****");
            Customer[] customerList = new Customer[] { customer1, customer2, customer3 };
            customerManager.List(customerList);


        }
    }
}
