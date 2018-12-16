using DiceGame.Game;
using DiceGame.Menus;
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

        public GuiController()
        {

        }

        public void ShowMenu()

        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowMainMenu();

        }
       

    }
}
