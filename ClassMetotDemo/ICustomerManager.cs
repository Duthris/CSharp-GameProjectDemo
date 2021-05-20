using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    interface ICustomerManager
    {
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Customer customer);
        public void List(Customer customer);

    }
}
