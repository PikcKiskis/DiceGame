using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class DiceGameScreen
    {

        private List<Player> PlayerList = new List<Player>();

        public DiceGameScreen()
        {

        }
        public void AddPlayer(Player player)
        {
            PlayerList.Add(player);

        }

        public void Render()
        {
        
            foreach (Player player in PlayerList)
            {
                player.PrintInfo();
            }
        }


    }
}
