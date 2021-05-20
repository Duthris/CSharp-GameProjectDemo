using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICustomerService
    {
        void Add(IEntity player);
        void Save(IEntity player);
        void Delete(IEntity player);
        void Update(IEntity player);
                        
    }
}
