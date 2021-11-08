using Ders5Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders5Odev5.Entities
{
    public class PlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            PlayerCheckManager playerCheckManager = new PlayerCheckManager();
            if (playerCheckManager.PlayerCheck(player))
            {
                Console.WriteLine("Player added.");
            }
            else
            {
                Console.WriteLine("Player not added.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted.");
        }

        public void Update(Player player)
        {
            PlayerCheckManager playerCheckManager = new PlayerCheckManager();
            if (playerCheckManager.PlayerCheck(player))
            {
                Console.WriteLine("Player updated.");
            }
            else
            {
                Console.WriteLine("Player not updated.");
            }
        }
    }
}
