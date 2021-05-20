using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        List<Sale> sales = new List<Sale>();
        public int saleCounter = 0;
        public void GetSales()
        {
            foreach (Sale sale in sales)
            {
                Console.WriteLine("Satış Numarası: " + sale.Id);
                Console.WriteLine("Satın Alan Kullanıcı: " + sale.CustomerName);
                Console.WriteLine("Satış Zamanı: " + sale.SaleTime);
                Console.WriteLine("Oyun Adı: " + sale.GameName);
                Console.WriteLine("------------------------------------------");
            }
        }

        public void Sale(Player player, Game game)
        {
            
            player.Balance = player.Balance - game.Price;

            Sale tempSale = new Sale();
            tempSale.Id = saleCounter + 1;
            tempSale.SaleTime = DateTime.Now;
            tempSale.CustomerName = player.FirstName + " " + player.LastName;
            tempSale.GameName = game.Name;
            saleCounter = saleCounter + 1;
            sales.Add(tempSale);

        }

        public void SaleWithDiscount(Player player, Game game, Campaign campaign)
        {
        
            player.Balance = player.Balance - (game.Price - (game.Price * (campaign.Discount / 100)));
            Sale tempSale = new Sale();
            tempSale.Id = saleCounter + 1;
            tempSale.SaleTime = DateTime.Now;
            tempSale.CustomerName = player.FirstName + " " + player.LastName;
            tempSale.GameName = game.Name;
            saleCounter = saleCounter + 1;
            sales.Add(tempSale);

        }
    }
}
