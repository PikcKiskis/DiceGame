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
        
        Random random = new Random();

        public DiceGameScreen()
        {

        }
        public void AddPlayer(Player player)
        {
            PlayerList.Add(player);

        }

        public List<int> PlayerRolls(int diceAmountForPlayer)
        {
            List<int> dicesPoints = new List<int>();
            for (int j = 0; j < diceAmountForPlayer; j++)
            {

                dicesPoints.Add(random.Next(1, 6));

            }
            return dicesPoints;
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
