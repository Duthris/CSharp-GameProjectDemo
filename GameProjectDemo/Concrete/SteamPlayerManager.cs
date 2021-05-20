using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class SteamPlayerManager:BaseCustomerManager
    {
        private IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }

            else
            {
                Console.WriteLine("Not a valid person. Cannot be saved on db as player.");
            }
        }
    }
}
