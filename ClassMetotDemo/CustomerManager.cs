using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri başarıyla eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri başarıyla silindi.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri listelendi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteriler başarıyla güncellendi.");
        }
    }
}
