using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menu
{
    class MainMenu : Window
    {
        private Button creditsButton;
        private Button quitButton;
        private Button startButton;
        private TextBlock titleTextBlock;
        private TextLine menuControlExplanationLine;
        private List<Button> mainMenuButtons;

        public MainMenu() : base(0, 0, 80, 25, '%')
        {

            titleTextBlock = new TextBlock(15, 5, 50, new List<string> { "Game", "By Aiste Lebedeva", "Made in Vilnius Coding School!", "", "()()", " (-.-)", "     o_(\")(\")" });
            startButton = new Button(5, 14, 18, 5, "Play");
            creditsButton = new Button(30, 14, 18, 5, "Credits");
            quitButton = new Button(55, 14, 18, 5, "Quit");

            menuControlExplanationLine = new TextLine(15, 22, 50, "Press P - Play, C - Credits, Q - Quit");

            mainMenuButtons = new List<Button>() { startButton, creditsButton, quitButton };
            startButton.SetActive();
            creditsButton.SetInActive();
            quitButton.SetInActive();

            Render();
        }


        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();
            menuControlExplanationLine.Render();

            foreach (var button in mainMenuButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);

        }

        public void ShowMainMenu()
        {
            Render();
        }

        public void ActivateButtonRight(int i)
        {

            mainMenuButtons.ElementAt(i - 1).SetInActive();
            mainMenuButtons.ElementAt(i).SetActive();
            mainMenuButtons.ElementAt(i - 1).Render();
            mainMenuButtons.ElementAt(i).Render();

        }

        public void ActivateButtonLeft(int i)
        {


            mainMenuButtons.ElementAt(i + 1).SetInActive();
            mainMenuButtons.ElementAt(i).SetActive();
            mainMenuButtons.ElementAt(i + 1).Render();
            mainMenuButtons.ElementAt(i).Render();

        }

    }
}
