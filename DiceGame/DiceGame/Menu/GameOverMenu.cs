using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menu
{
    class GameOverMenu : Window
    {
        private TextLine gaweOverTextLine;
        private TextLine winnerTextline;
        private TextLine gameOverSelectionMenuTextLine;
        

        public GameOverMenu() : base(0, 0, 80, 25, '%')
        {

            gaweOverTextLine = new TextLine(15, 10, 50, "GAME OVER!");
            winnerTextline = new TextLine(15, 12, 50, "The winner is Player 2");
            gameOverSelectionMenuTextLine = new TextLine(15, 22, 50, "R - Replay same, M - Go to menu. Q - Quit.");

            Render();
        }


        public override void Render()
        {
            base.Render();
            gaweOverTextLine.Render();
            winnerTextline.Render();
            gameOverSelectionMenuTextLine.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void ShowGameOverSelectionMenu()
        {
            Render();
        }
    }
}
