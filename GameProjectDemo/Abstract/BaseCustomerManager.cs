using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public class BaseCustomerManager : ICustomerService, IGameService
    {
        public void Add(Game game)
        {
            throw new NotImplementedException();
        }

        public void Add(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity player)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Player player)
        {
            Console.WriteLine("Saved to db: " + player.FirstName);
        }

        public void Save(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity player)
        {
            throw new NotImplementedException();
        }
    }
}
