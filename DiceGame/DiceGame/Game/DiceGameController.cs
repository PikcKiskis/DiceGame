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

        //private int playerSelectionAmount;
        //private int diceAmountForPlayer;
        private int playerDiceSum = 0;
        private List<int> DiceSums = new List<int>();
        private List<int> dicesPoints= new List<int>();
        private Dictionary<string, int> playersResults = new Dictionary<string, int>();


        Random random = new Random();

        public DiceGameController()
        {
            //this.playerSelectionAmount = playerSelectionAmount;
            //this.diceAmountForPlayer = diceAmountForPlayer;
        }

        public void StartGame(int playerSelectionAmount, int diceAmountForPlayer)
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
                string playerWithCount = String.Concat("Player", playerCount);
                diceGameScreen.AddPlayer(new Player(playerWithCount, dicesPoints , playerDiceSum));
                playerCount++;

                playersResults.Add(playerWithCount, playerDiceSum);
            }

            //diceGameScreen.Render();


            do
            {
                //Console.Clear();

                diceGameScreen.Render();
                int maximum = DiceSums.Max();
                winner = DiceSums.FindIndex(x => x == maximum);



                //(playersResults.Values.Count == playersResults.Values.Distinct().Count())
                if (DiceSums.Count == DiceSums.Distinct().Count())
                {
                    Console.ReadKey();
                    GameOverMenu gameOverMenu = new GameOverMenu(winner);
                    gameOverMenu.ShowGameOverSelectionMenu(playerSelectionAmount, diceAmountForPlayer );
                    needToRender = false;
                } else
                {
                    Console.WriteLine("EVEN");
                    List<string> evenPlayers = new List<string>(); // vienodai tasku surinke zaidejai
                    evenPlayers = playersResults.Where(pair => pair.Value == DiceSums.FirstOrDefault())
                                                    .Select(pair => pair.Key).ToList();

                    playersResults.Clear();
                    DiceSums.Clear();
                    diceGameScreen.ClearPlayers();
                    foreach (string player in evenPlayers)
                    {
                        dicesPoints = diceGameScreen.PlayerRolls(diceAmountForPlayer);
                        playerDiceSum = dicesPoints.Sum();
                        DiceSums.Add(playerDiceSum);
                        diceGameScreen.AddPlayer(new Player(player, dicesPoints, playerDiceSum));

                        playersResults.Add(player, playerDiceSum);
                    }

                    Console.ReadKey();
 
                }
         



            } while (needToRender);


        }



    }
}
