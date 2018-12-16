using DiceGame.GUI;
using DiceGame.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menus
{
    class MainMenu : Window
    {
        private int arrowPushed = 0;
        private bool checkingKeys = true;

        private TextBlock titleTextBlock;
        private TextLine menuControlExplanationLine;

        public MainMenu() : base(0, 0, 80, 25, '%')
        {

            titleTextBlock = new TextBlock(15, 5, 50, new List<string> { "Game", "By Aiste Lebedeva", "Made in Vilnius Coding School!", "", "()()", " (-.-)", "     o_(\")(\")" });
            menuControlExplanationLine = new TextLine(15, 22, 50, "Press P - Play, C - Credits, Q - Quit");

            Render();
        }


        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();
            menuControlExplanationLine.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void ShowMainMenu()

        {
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);

                switch (pressedChar.Key)
                {
                    case ConsoleKey.P:
                        {
                            PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
                            playerSelectionMenu.ShowPlayerSelectionMenu();
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            CreditWindow creditWindow = new CreditWindow();
                            creditWindow.Render();
                            Console.ReadKey();
                            ShowMainMenu();
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
