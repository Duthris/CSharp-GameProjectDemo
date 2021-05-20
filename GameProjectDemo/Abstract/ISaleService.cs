using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleService
    {
        public void Sale(Player player, Game game);
        public void SaleWithDiscount(Player player, Game game, Campaign campaign);
        public void GetSales();
    }
}
