using System;
using System.Collections.Generic;
using System.Text;

namespace Hws
{
    interface IProductManager
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);

    }
}
