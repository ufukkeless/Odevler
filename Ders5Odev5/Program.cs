using Ders5Odev5.Entities;
using System;

namespace Ders5Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            Player player = new Player();
            player.Email = "ufukkeles93@hotmail.com";
            player.FirsName = "Ufuk";
            player.Id = 1;
            player.LastName = "Keleş";
            player.PlayerName = "ASYA";

            playerManager.Add(player);



        }
    }
}
