using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Anıl",
                Surname = "YALIMDEMIR",
                Age = 20,
                Gender = "Erkek",
                IdentityNumber = 12345,
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Adem",
                Surname = "YALIMDEMIR",
                Age = 24,
                Gender = "Erkek",
                IdentityNumber = 54321,
            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Ayşe",
                Surname = "EŞYA",
                Age = 21,
                Gender = "Kadın",
                IdentityNumber = 32154,
            };

            Customer[] customers = new Customer[]
            {
                customer1, customer3
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Delete(customer2);
            customerManager.Update(customer2);

            Console.WriteLine("\n\nGüncellemeden sonraki sistemde kayıtlı müşteri bilgileri:");
            Console.WriteLine("--------------------------------------------");

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri numarası: " + customer.Id + "\nMüşteri Adı: " + customer.Name + 
                    "\nMüşteri Soyadı: " + customer.Surname + "\nMüşteri Yaşı: " + customer.Age + 
                    "\nMüşteri Cinsiyeti: " + customer.Gender + "\nMüşteri Tc No: " + customer.IdentityNumber);

                Console.WriteLine("--------------------------------------------");
            }
   

        }
    }
}
