using DiceGame.Game;
using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menus
{
    class GameOverMenu : Window
    {
        private bool checkingKeys = true;
        private int winner;

        private TextLine gaweOverTextLine;
        private TextLine winnerTextline;
        private TextLine gameOverSelectionMenuTextLine;
        

        public GameOverMenu(int winner) : base(0, 0, 80, 25, '%')
        {
            this.winner = winner;
            gaweOverTextLine = new TextLine(15, 10, 50, "GAME OVER!");
            winnerTextline = new TextLine(15, 12, 50, "The winner is Player" + winner);
            gameOverSelectionMenuTextLine = new TextLine(15, 22, 50, "R - Replay same, M - Go to menu. Q - Quit.");

            
        }


        public override void Render()
        {
            base.Render();
            gaweOverTextLine.Render();
            winnerTextline.Render();
            gameOverSelectionMenuTextLine.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void ShowGameOverSelectionMenu(int playerSelectionAmount, int diceAmountForPlayer)
        {
            Render();

            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.R:
                        {
                            Console.Clear();
                            DiceGameController diceGameController = new DiceGameController();
                            diceGameController.StartGame(playerSelectionAmount, diceAmountForPlayer);
                            break;
                            
                        }
                    case ConsoleKey.M:
                        {
                            Console.Clear();
                            MainMenu mainMenu = new MainMenu();
                            mainMenu.ShowMainMenu();
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            } while (checkingKeys);
        }
    }
}
