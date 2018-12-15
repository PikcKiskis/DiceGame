using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menu
{
    class DiceSelectionMenu : Window
    {
        private TextLine diceSelectionTextLine;
        private TextLine menuControlExplanationLine;

        public DiceSelectionMenu() : base(0, 0, 80, 25, '%')
        {

            diceSelectionTextLine = new TextLine(15, 10, 50, "Player Will Have 3 Dice" );
            menuControlExplanationLine = new TextLine(15, 22, 50, "Use + / - keys to change dice amount");

            Render();
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
        }

    }
}
