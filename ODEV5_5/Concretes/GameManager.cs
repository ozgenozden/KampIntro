using ODEV5_5.Abstracts;
using ODEV5_5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5_5.Concretes
{
    class GameManager : IGameService
    {

        ICampaingService _campaingService;

        public GameManager(ICampaingService campaingService)
        {
            _campaingService = campaingService;
        }
        public void GameSale(Gamer gamer,Game game)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncuya " + game.GameName + " adlı oyun satışı yapılmıştır.");
        }

    }
}
