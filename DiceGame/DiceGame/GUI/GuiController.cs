using DiceGame.Game;
using DiceGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class GuiController
    {
        private int arrowPushed = 0;
        private bool checkingKeys = true;

        public GuiController()
        {

        }

        public void ShowMenu()

        {
            GameWindow gameWindow = new GameWindow();
            {
                do
                {
                    //while (Console.KeyAvailable)
                    //{
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {

                        case ConsoleKey.RightArrow:
                            arrowPushed++;
                            if (arrowPushed < 3 && arrowPushed >= 0)
                            {
                                gameWindow.ActivateButtonRight(arrowPushed);
                            }
                            else
                            {
                                arrowPushed--;
                                gameWindow.ActivateButtonRight(arrowPushed);
                            }

                            break;
                        case ConsoleKey.LeftArrow:
                            arrowPushed--;
                            if (arrowPushed >= 0 && arrowPushed < 3)
                            {
                                gameWindow.ActivateButtonLeft(arrowPushed);
                            }
                            else
                            {
                                arrowPushed++;
                                gameWindow.ActivateButtonLeft(arrowPushed);
                            }

                            break;
                        case ConsoleKey.Enter:
                            switch (arrowPushed)
                            {
                                case 0:
                                    RenderGame();
                                    break;
                                case 1:
                                    RenderCreditWindow();
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;
                            }
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                    }
                    //}

                } while (checkingKeys);
            }

        }


        public void RenderCreditWindow()
        {
            arrowPushed = 0;
            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();
            Console.ReadKey();
            ShowMenu();

        }

        public void RenderGame()
        {
            GameController gameController = new GameController();
            gameController.StartGame();

        }

    }
}
