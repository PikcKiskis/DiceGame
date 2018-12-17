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
        private int playerDiceSum = 0;
        private List<int> DiceSums = new List<int>();
        private List<int> dicesPoints= new List<int>();


        Random random = new Random();

        public DiceGameController(int playerSelectionAmount, int diceAmountForPlayer)
        {
            this.playerSelectionAmount = playerSelectionAmount;
            this.diceAmountForPlayer = diceAmountForPlayer;
        }

        public void StartGame()
        {
            int winner = 0;
            bool needToRender = true;
            Console.Clear();
            DiceGameScreen diceGameScreen = new DiceGameScreen();
            
            
            int playerCount = 0;

            for (int i = 0; i < playerSelectionAmount; i++)
            {
                
                dicesPoints = diceGameScreen.PlayerRolls(diceAmountForPlayer);
                playerDiceSum = dicesPoints.Sum();
                DiceSums.Add(playerDiceSum);

                diceGameScreen.AddPlayer(new Player("Player" + playerCount , dicesPoints , playerDiceSum));
                playerCount++;

            }

            //diceGameScreen.Render();


            do
            {
                //Console.Clear();

                diceGameScreen.Render();
                int maximum = DiceSums.Max();
                winner = DiceSums.FindIndex(x => x == maximum);




                if (DiceSums.Count == DiceSums.Distinct().Count())
                {
                    System.Threading.Thread.Sleep(3000);
                    GameOverMenu gameOverMenu = new GameOverMenu(winner);
                    gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer );
                    needToRender = false;
                } else
                {
                    Console.WriteLine("EVEN");
                    System.Threading.Thread.Sleep(3000);
                    GameOverMenu gameOverMenu = new GameOverMenu(winner);
                    gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer);
                    needToRender = false;
                }
         



            } while (needToRender);


        }



    }
}
