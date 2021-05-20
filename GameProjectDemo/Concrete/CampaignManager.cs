using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> campaignList = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            campaignList.Add(campaign);
            Console.WriteLine("'" + campaign.Name + "' başarıyla eklendi.");
        }

        public void ApplyDiscountToGame(Game game, Campaign campaign)
        {
            Console.WriteLine("\n%" + campaign.Discount + " indirim " + game.Name + " isimli oyuna uygulandı.");
            Console.WriteLine(game.Name + " isimli oyunun yeni fiyatı: " + (game.Price - (game.Price * campaign.Discount / 100) + "TL."));
        }

        public void Delete(Campaign campaign)
        {
            campaignList.Remove(campaign);
            Console.WriteLine(campaign.Name + " adlı kampanya başarıyla sistemden silindi.");
        }

        public void GetCampaigns(Campaign campaign)
        {
            Console.WriteLine("\n**************** Mevcut Kampanyalar ***************");

            foreach (Campaign campaigns in campaignList)
            {
                Console.WriteLine("Kampanya Id: " + campaigns.Id);
                Console.WriteLine("Kampanya Adı: " + campaigns.Name);
                Console.WriteLine("Kampanya İndirim Oranı: %" + campaigns.Discount);
                System.Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("***************************************************\n");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + "adlı kampanya başarıyla sistemde güncellendi.");
        }
    }
}
