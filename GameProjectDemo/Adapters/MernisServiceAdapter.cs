using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(player.NationalityId, player.FirstName,
                player.LastName, player.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

            return result;
        }
    }
}
