using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class DiceGameScreen
    {


        private string winner;
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

          
            //int place = DiceSums.ElementAt(DiceSums.Max());

            //switch(place)
            //{
            //    case 0:
            //    {
            //        winner = "Player0";
            //        break;
            //    }
            //    case 1:
            //        {
            //            winner = "Player1";
            //            break;
            //        }
            //    case 2:
            //        {
            //            winner = "Player2";
            //            break;
            //        }
            //    case 3:
            //        {
            //            winner = "Player3";
            //            break;
            //        }
            //    case 4:
            //        {
            //            winner = "Player4";
            //            break;
            //        }
            //    case 5:
            //        {
            //            winner = "Player5";

            //            break;
            //        }


            //}
            //Console.WriteLine("The Winner is: " + winner);
           

        }


    }
}
