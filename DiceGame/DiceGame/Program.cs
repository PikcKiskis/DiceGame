using DiceGame.Game;
using DiceGame.GUI;
using DiceGame.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GuiController guiController = new GuiController();
            GameController gameController = new GameController();
            //gameController.StartGame();
            guiController.ShowMenu();

            //MainMenu mainMenu = new MainMenu();
            //mainMenu.ShowMainMenu();
            //PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
            //playerSelectionMenu.ShowPlayerSelectionMenu();

            //DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu();
            //diceSelectionMenu.ShowDiceSelectionMenu();

            //GameOverMenu gameOverMenu = new GameOverMenu();
            //gameOverMenu.ShowGameOverSelectionMenu();
            Console.ReadKey();

        }
    }
}
