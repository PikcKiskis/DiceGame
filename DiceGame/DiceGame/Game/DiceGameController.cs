﻿using DiceGame.Menus;
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

            diceGameScreen.Render();


            do
            {
                Console.Clear();

                diceGameScreen.Render();

                System.Threading.Thread.Sleep(3000);
                GameOverMenu gameOverMenu = new GameOverMenu();
                gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer);

            } while (needToRender);


        }



    }
}
