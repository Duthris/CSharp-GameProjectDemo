using System;
using System.Collections.Generic;
using System.Text;

namespace Hws
{
    class ProductManager : IProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " adlı ürün başarıyla eklendi.");
        }

        public void Delete(Product product)
        {
            Console.WriteLine(product.Name + " adlı ürün başarıyla silindi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.Name + " adlı ürün başarıyla güncellendi.");
        }
    }
}
