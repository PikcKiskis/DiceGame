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
   
        private bool checkingKeys = true;

        private TextLine playersCount;
        private TextLine diceSelectionTextLine;
        private TextLine menuControlExplanationLine;

        private int diceAmountForPlayer = 3;
        //private int playerSelectionAmount;
      
        


        public DiceSelectionMenu() : base(0, 0, 80, 25, '%')
        {
            

            
            diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have " + diceAmountForPlayer +" Dice" );
            menuControlExplanationLine = new TextLine(15, 22, 50, "Use + / - keys to change dice amount");
           
        }


        public override void Render()
        {
            base.Render();
            playersCount.Render();
            diceSelectionTextLine.Render();
            menuControlExplanationLine.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void ShowDiceSelectionMenu(int playerSelectionAmount)
        {
            switch (playerSelectionAmount)
            {
                case 0:
                    {
                        playersCount = new TextLine(15, 5, 50, "P2 Selected");
                        break;
                    }
                case 1:
                    {
                        playersCount = new TextLine(15, 5, 50, "P3 Selected");
                        break;
                    }
                case 2:
                    {
                        playersCount = new TextLine(15, 5, 50, "P4 Selected");
                        break;
                    }
                case 3:
                    {
                        playersCount = new TextLine(15, 5, 50, "P5 Selected");
                        break;
                    }
                case 4:
                    {
                        playersCount = new TextLine(15, 5, 50, "P6 Selected");
                        break;
                    }
                case 5:
                    {
                        playersCount = new TextLine(15, 5, 50, "P7 Selected");
                        break;
                    }

            }
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
                            DiceGameController diceGameController = new DiceGameController();
                            diceGameController.StartGame(playerSelectionAmount + 2, diceAmountForPlayer);
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
