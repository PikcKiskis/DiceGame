using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menu
{
    class PlayerSelectionMenu : Window
    {
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
            Render();
        }

        public void ActivateButtonRight(int i)
        {

            playerSelectionMenuButtons.ElementAt(i - 1).SetInActive();
            playerSelectionMenuButtons.ElementAt(i).SetActive();
            playerSelectionMenuButtons.ElementAt(i - 1).Render();
            playerSelectionMenuButtons.ElementAt(i).Render();

        }

        public void ActivateButtonLeft(int i)
        {


            playerSelectionMenuButtons.ElementAt(i + 1).SetInActive();
            playerSelectionMenuButtons.ElementAt(i).SetActive();
            playerSelectionMenuButtons.ElementAt(i + 1).Render();
            playerSelectionMenuButtons.ElementAt(i).Render();

        }
    }
}
