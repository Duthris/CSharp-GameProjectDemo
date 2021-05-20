using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager playerManager = new SteamPlayerManager(new MernisServiceAdapter());

            Player player1 = new Player
            {
                Id = 1,
                DateOfBirth = new DateTime(2000, 7, 20),
                FirstName = "Adem Anıl",
                LastName = "Yalımdemir",
                NationalityId = 31898006836,
                Balance = 300,
            };

            playerManager.Save(player1);

            Campaign summerCampaign = new Campaign
            {
                Id = 1,
                Name = "Yaz Kampanyası",
                Discount = 15,
            };

            Campaign winterCampaign = new Campaign
            {
                Id = 2,
                Name = "Kış Kampanyası",
                Discount = 20,
            };

            Campaign bigBangCampaign = new Campaign
            {
                Id = 3,
                Name = "BigBang Kampanyası",
                Discount = 25,
            };

            SaleManager saleManager = new SaleManager();
            CampaignManager campaignManager = new CampaignManager();

            Game rdr2 = new Game() { Name = "Red Dead Redemption 2", Price = 200 };
            Game valheim = new Game() { Name = "Valheim", Price = 32 };
            Game csGO = new Game() { Name = "CS:GO", Price = 60 };

            campaignManager.Add(summerCampaign);
            campaignManager.Add(winterCampaign);
            campaignManager.Add(bigBangCampaign);

            campaignManager.Delete(winterCampaign);
                                  
            campaignManager.ApplyDiscountToGame(rdr2, summerCampaign);

            saleManager.SaleWithDiscount(player1, valheim, summerCampaign);
            Console.WriteLine(player1.FirstName + " adlı müşterinin cüzdanında kalan bakiye: " + player1.Balance + "TL");
             
            campaignManager.GetCampaigns(bigBangCampaign);
            saleManager.GetSales();

            Console.ReadLine();
            
        }
    }
}
