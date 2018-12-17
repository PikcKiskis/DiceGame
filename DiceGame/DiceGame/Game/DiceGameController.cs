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

        private List<int> dicesPoints= new List<int>();


        Random random = new Random();

        public DiceGameController(int playerSelectionAmount, int diceAmountForPlayer)
        {
            this.playerSelectionAmount = playerSelectionAmount;
            this.diceAmountForPlayer = diceAmountForPlayer;
        }

        public void StartGame()
        {
            bool needToRender = true;
            Console.Clear();
            DiceGameScreen diceGameScreen = new DiceGameScreen();
            
            
            int playerCount = 0;

            for (int i = 0; i < playerSelectionAmount; i++)
            { 

                dicesPoints = diceGameScreen.PlayerRolls(diceAmountForPlayer);
                playerDiceSum = dicesPoints.Sum();
                diceGameScreen.AddPlayer(new Player("Player" + playerCount , dicesPoints , playerDiceSum));
                playerCount++;

            }

            diceGameScreen.Render();

            do
            {
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                    }
                }
                diceGameScreen.Render();

                System.Threading.Thread.Sleep(250);

            } while (needToRender);


            //GameOverMenu gameOverMenu = new GameOverMenu();
            //gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer);
        }



    }
}
