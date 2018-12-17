using DiceGame.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class DiceGameController
    {

        private int playerSelectionAmount;
        private int diceAmountForPlayer;

        private List<int> dicesPoints= new List<int>();

        Random random = new Random();

        public DiceGameController(int playerSelectionAmount, int diceAmountForPlayer)
        {
            this.playerSelectionAmount = playerSelectionAmount;
            this.diceAmountForPlayer = diceAmountForPlayer;
        }

        public void StartGame()
        {
            Console.Clear();
            DiceGameScreen diceGameScreen = new DiceGameScreen();
            
            
            int playerCount = 0;

            List<Player> playerList = new List<Player>();
            for (int i = 0; i < playerSelectionAmount; i++)
            { 

                dicesPoints = diceGameScreen.PlayerRolls(diceAmountForPlayer);
                diceGameScreen.AddPlayer(new Player("Player" + playerCount , dicesPoints));
                playerCount++;




            }

            diceGameScreen.Render();


            //GameOverMenu gameOverMenu = new GameOverMenu();
            //gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer);
        }



    }
}
