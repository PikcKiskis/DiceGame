using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class GameController
    {

        public GameController()
        {

        }
        public void StartGame()
        {
            bool needToRender = true;

            GameScreen myGame = new GameScreen(80, 80);
            Hero hero = new Hero(10, 10, "Herojus");

            myGame.SetHero(hero);

            int enemyCount = 0;
            Random rnd = new Random();


            List<Enemy> enemiesList = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyCount, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyCount));
                enemyCount++;
            }

            myGame.Render();


            myGame.GetHero().MoveRight();
            myGame.MoveAllEnemiesDown();

            Enemy secondEnemy = myGame.GetEnemyById(1);
            if (secondEnemy != null)
            {
                secondEnemy.MoveDown();
            }

            myGame.Render();

            do
            {
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            GuiController gui = new GuiController();
                            gui.ShowMenu();
                            break;
                        case ConsoleKey.RightArrow:
                            hero.MoveRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            hero.MoveLeft();
                            break;
                    }
                }
                myGame.Render();

                System.Threading.Thread.Sleep(250);

            } while (needToRender);

        }
    }
}
