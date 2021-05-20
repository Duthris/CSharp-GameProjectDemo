using System;

namespace Hws
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product()
            {
                Id = 1,
                Name = "Laptop",
                Color = "Beyaz",
                Category = "Elektronik",
                Amount = 10,
                Price = 6000
            };

            Product product2 = new Product()
            {
                Id = 2,
                Name = "Gömlek",
                Color = "Siyah",
                Category = "Giyim",
                Amount = 95,
                Price = 45
            };

            Product product3 = new Product()
            {
                Id = 3,
                Name = "Koltuk takımı",
                Color = "Yeşil",
                Category = "Mobilya",
                Amount = 15,
                Price = 750
            };

            Product product4 = new Product()
            {
                Id = 4,
                Name = "Lamba",
                Color = "Mavi",
                Category = "Ev Aletleri",
                Amount = 0,
                Price = 25
            };

            Product[] products = new Product[]
            {
                product1, product2, product3
            };

            Product[] oProducts = new Product[]
            {
                product4
            };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Add(product3);
            productManager.Delete(product4);


            Console.WriteLine("\n-------- For Loop --------\n");

            Console.WriteLine("\nSistemde Kayıtlı Ürünler\n");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Id: " + products[i].Id + "\nÜrün Adı: " + products[i].Name + 
                    "\nÜrün Rengi: " + products[i].Color + "\nÜrün Kategorisi: " + products[i].Category + 
                    "\nÜrün Adedi: " + products[i].Amount + "\nÜrün Fiyatı: " + products[i].Price + " TL\n");
            }

            Console.WriteLine("\nSistemden Silinen Tükenmiş Ürünler\n");

            for (int i = 0; i < oProducts.Length; i++)
            {
                Console.WriteLine("Ürün Id: " + oProducts[i].Id + "\nÜrün Adı: " + oProducts[i].Name +
                    "\nÜrün Rengi: " + oProducts[i].Color + "\nÜrün Kategorisi: " + oProducts[i].Category +
                    "\nÜrün Adedi: " + oProducts[i].Amount + "\nÜrün Fiyatı: " + oProducts[i].Price + " TL\n");
            }


            Console.WriteLine("\n-------- Foreach Loop --------\n");

            Console.WriteLine("\nSistemde Kayıtlı Ürünler\n");

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Id: " + product.Id + "\nÜrün Adı: " + product.Name +
                   "\nÜrün Rengi: " + product.Color + "\nÜrün Kategorisi: " + product.Category +
                   "\nÜrün Adedi: " + product.Amount + "\nÜrün Fiyatı: " + product.Price + " TL\n");
            }

            Console.WriteLine("\nSistemden Silinen Tükenmiş Ürünler\n");

            foreach (Product oProduct in oProducts)
            {
                Console.WriteLine("Ürün Id: " + oProduct.Id + "\nÜrün Adı: " + oProduct.Name +
                    "\nÜrün Rengi: " + oProduct.Color + "\nÜrün Kategorisi: " + oProduct.Category +
                    "\nÜrün Adedi: " + oProduct.Amount + "\nÜrün Fiyatı: " + oProduct.Price + " TL\n");
            }


            Console.WriteLine("\n-------- While Loop --------\n");

            Console.WriteLine("\nSistemde Kayıtlı Ürünler\n");

            int counter = 0;

            while (counter < products.Length)
            {
                Console.WriteLine("Ürün Id: " + products[counter].Id + "\nÜrün Adı: " + products[counter].Name +
                   "\nÜrün Rengi: " + products[counter].Color + "\nÜrün Kategorisi: " + products[counter].Category +
                   "\nÜrün Adedi: " + products[counter].Amount + "\nÜrün Fiyatı: " + products[counter].Price + " TL\n");

                counter++;
            }

            Console.WriteLine("\nSistemden Silinen Tükenmiş Ürünler\n");

            int counter2 = 0;

            while (counter2 < oProducts.Length)
            {
                Console.WriteLine("Ürün Id: " + oProducts[counter2].Id + "\nÜrün Adı: " + oProducts[counter2].Name +
                    "\nÜrün Rengi: " + oProducts[counter2].Color + "\nÜrün Kategorisi: " + oProducts[counter2].Category +
                    "\nÜrün Adedi: " + oProducts[counter2].Amount + "\nÜrün Fiyatı: " + oProducts[counter2].Price + " TL\n");

                counter2++;
            }
        }
    }
}
