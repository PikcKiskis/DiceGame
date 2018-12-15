using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.View
{
    class GameWindow : Window
    {
        private Button creditsButton;
        private Button quitButton;
        private Button startButton;
        private TextBlock titleTextBlock;
        private List<Button> gameWindowButtons;

        public GameWindow() : base(0, 0, 80, 25, '%')
        {

            titleTextBlock = new TextBlock(15, 5, 50, new List<string> { "Game", "By Aiste Lebedeva", "Made in Vilnius Coding School!", "", "()()", " (-.-)", "     o_(\")(\")" });
            startButton = new Button(5, 18, 18, 5, "Start");
            creditsButton = new Button(30, 18, 18, 5, "Credits");
            quitButton = new Button(55, 18, 18, 5, "Quit");

            gameWindowButtons = new List<Button>() { startButton, creditsButton, quitButton };
            startButton.SetActive();
            creditsButton.SetInActive();
            quitButton.SetInActive();

            Render();
        }


        public override void Render()
        {
            base.Render();
            titleTextBlock.Render();

            foreach (var button in gameWindowButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);

        }

        public void ShowMenu()
        {
            Render();
        }

        public void ActivateButtonRight(int i)
        {

            gameWindowButtons.ElementAt(i - 1).SetInActive();
            gameWindowButtons.ElementAt(i).SetActive();
            gameWindowButtons.ElementAt(i - 1).Render();
            gameWindowButtons.ElementAt(i).Render();

        }

        public void ActivateButtonLeft(int i)
        {


            gameWindowButtons.ElementAt(i + 1).SetInActive();
            gameWindowButtons.ElementAt(i).SetActive();
            gameWindowButtons.ElementAt(i + 1).Render();
            gameWindowButtons.ElementAt(i).Render();

        }


    }
}
