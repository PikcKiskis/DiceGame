using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Menus
{
    class Menu
    {
        public Menu() {

        }


        public void ShowMainMenu()
        {
            MainMenu mainMenu = new MainMenu();
        }

        public void ShowPlayerSelectionMenu()
        {
            PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
        }

        public void ShowDiceSelectionMenu()
        {
            DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu();

        }

        public void GameOverMenu()
        {
            GameOverMenu gameOverMenu = new GameOverMenu();
        }
    }
}
