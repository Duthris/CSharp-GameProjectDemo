using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ICampaignService
    {
        public void ApplyDiscountToGame(Game game, Campaign campaign);
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);
        public void GetCampaigns(Campaign campaign);

    }
}
