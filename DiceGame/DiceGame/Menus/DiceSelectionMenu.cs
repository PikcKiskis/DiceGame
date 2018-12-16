using DiceGame.Game;
using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menus
{
    class DiceSelectionMenu : Window
    {
        private int arrowPushed = 0;
        private bool checkingKeys = true;

        private TextLine diceSelectionTextLine;
        private TextLine menuControlExplanationLine;

        private int diceAmountForPlayer = 3;
      

        public DiceSelectionMenu() : base(0, 0, 80, 25, '%')
        {

            diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer +" Dice" );
            menuControlExplanationLine = new TextLine(15, 22, 50, "Use + / - keys to change dice amount");
           
        }


        public override void Render()
        {
            base.Render();
            diceSelectionTextLine.Render();
            menuControlExplanationLine.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void ShowDiceSelectionMenu()
        {
            Render();
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.OemPlus: 
                        {
                            diceAmountForPlayer++;
                            diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer + " Dice" );
                            diceSelectionTextLine.Render();
                            break;
                        }
                    case ConsoleKey.OemMinus:
                        {
                            if(diceAmountForPlayer>1)
                            {
                                diceAmountForPlayer--;
                                diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer + " Dice");
                                diceSelectionTextLine.Render();
                            }
                            
                            break;
                        }
                    case ConsoleKey.Add:
                        {
                            diceAmountForPlayer++;
                            diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer + " Dice");
                            diceSelectionTextLine.Render();
                            break;
                        }
                    case ConsoleKey.Subtract:
                        {
                            if (diceAmountForPlayer > 1)
                            {
                                diceAmountForPlayer--;
                                diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer + " Dice");
                                diceSelectionTextLine.Render();
                            }

                            break;
                        }
                    case ConsoleKey.Enter:
                        {
                            GameController gameController = new GameController();
                            gameController.StartGame();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Environment.Exit(0);
                            break;
                        }


                }
            } while (checkingKeys);
        }

    }
}
