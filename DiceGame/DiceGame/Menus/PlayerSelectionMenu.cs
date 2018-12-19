using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menus
{
    class PlayerSelectionMenu : Window
    {
        private int arrowPushed = 0;
        private int down = 0;
        private bool checkingKeys = true;

        private Button p2Button;
        private Button p3Button;
        private Button p4Button;
        private Button p5Button;
        private Button p6Button;
        private Button p7Button;

        private TextLine menuControlExplanationLine;

        private List<Button> playerSelectionMenuButtons;

        public PlayerSelectionMenu() : base(0, 0, 80, 25, '%')
        {

            p2Button = new Button(5, 6, 18, 5, "P2");
            p3Button = new Button(30, 6, 18, 5, "P3");
            p4Button = new Button(55, 6, 18, 5, "P4");
            p5Button = new Button(5, 14, 18, 5, "P5");
            p6Button = new Button(30, 14, 18, 5, "P6");
            p7Button = new Button(55, 14, 18, 5, "P7");

            menuControlExplanationLine = new TextLine(15, 22, 50, "Use Right / Left / Up / Down keys to select players");

            playerSelectionMenuButtons = new List<Button>() { p2Button, p3Button, p4Button, p5Button, p6Button, p7Button };
            p2Button.SetActive();
            p3Button.SetInActive();
            p4Button.SetInActive();
            p5Button.SetInActive();
            p6Button.SetInActive();
            p7Button.SetInActive();

            Render();
        }


        public override void Render()
        {
            base.Render();

            menuControlExplanationLine.Render();

            foreach (var button in playerSelectionMenuButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);

        }

        public void ShowPlayerSelectionMenu()
        {      
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.RightArrow:
                        {
                            
                            arrowPushed++;
                            if (down == 0)
                            {
                                if (arrowPushed < 3 && arrowPushed >= 0)
                                {
                                    ActivateButtonRight(arrowPushed, down);
                                } else
                                {
                                    arrowPushed--;
                                    ActivateButtonRight(arrowPushed, down);
                                }

                            }
                            else if (down == 1)
                            {
                                if(arrowPushed <= 5 && arrowPushed >= 3)
                                {
                                    ActivateButtonRight(arrowPushed, down);
                                }
                                else
                                {
                                    arrowPushed--;
                                    ActivateButtonRight(arrowPushed, down);
                                }


                            }

                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            arrowPushed--;
                            if (down == 0)
                            {
                                if (arrowPushed >= 0 && arrowPushed < 3)
                                {
                                    ActivateButtonLeft(arrowPushed, down);
                                }
                                else
                                {
                                    arrowPushed++;
                                    ActivateButtonLeft(arrowPushed, down);
                                }

                            } else if (down == 1)
                            {
                                if (arrowPushed <= 5 && arrowPushed >= 3)
                                {
                                    ActivateButtonLeft(arrowPushed, down);
                                }
                                else
                                {
                                    arrowPushed++;
                                    ActivateButtonLeft(arrowPushed, down);
                                }
                            }
                 
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (down == 1)
                            {
                                down = 0;
                                arrowPushed = arrowPushed - 3;
                                ActivateButtonUp(arrowPushed, down);
                            }
                            
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if(down == 0)
                            {
                                down = 1;
                                arrowPushed = arrowPushed + 3;
                                ActivateButtonDown(arrowPushed, down);
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        {

                            DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu();
                            diceSelectionMenu.ShowDiceSelectionMenu(arrowPushed);
                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            Environment.Exit(0);
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

        public void ActivateButtonRight(int i, int down)
        {

                playerSelectionMenuButtons.ElementAt(i - 1).SetInActive();
                playerSelectionMenuButtons.ElementAt(i).SetActive();
                playerSelectionMenuButtons.ElementAt(i - 1).Render();
                playerSelectionMenuButtons.ElementAt(i).Render();

        }

        public void ActivateButtonLeft(int i, int down)
        {

                playerSelectionMenuButtons.ElementAt(i + 1).SetInActive();
                playerSelectionMenuButtons.ElementAt(i).SetActive();
                playerSelectionMenuButtons.ElementAt(i + 1).Render();
                playerSelectionMenuButtons.ElementAt(i).Render();

        }

        public void ActivateButtonUp(int i , int down)
        {
            playerSelectionMenuButtons.ElementAt(i+3).SetInActive();
            playerSelectionMenuButtons.ElementAt(i).SetActive();
            playerSelectionMenuButtons.ElementAt(i+3).Render();
            playerSelectionMenuButtons.ElementAt(i).Render();


        }

        public void ActivateButtonDown(int i, int down)
        {

            playerSelectionMenuButtons.ElementAt(i-3).SetInActive();
            playerSelectionMenuButtons.ElementAt(i).SetActive();
            playerSelectionMenuButtons.ElementAt(i-3).Render();
            playerSelectionMenuButtons.ElementAt(i).Render();
            

        }
    }
}
