using Ders5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Entities
{
    public class GameSellManager : IGameSellService
    {
        public void GameSell(Player player)
        {
            Console.WriteLine("Rise Online oyunu " + player.PlayerName +" tarafından satın alınmıştır.");
        }
    }
}
