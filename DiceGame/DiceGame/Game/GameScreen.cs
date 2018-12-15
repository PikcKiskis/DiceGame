using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class GameScreen
    {
        private int width;
        private int height;

        private Hero hero;
        private List<Enemy> enemiesList = new List<Enemy>();

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;

        }


        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }

        public Hero GetHero()
        {
            return hero;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemiesList.Add(enemy);

        }

        public void MoveAllEnemiesDown()
        {
            foreach (Enemy enemy in enemiesList)
            {
                enemy.MoveDown();
            }
        }

        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in enemiesList)
            {
                enemy.GetId();
                return enemy;
            }

            return null;
        }

        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in enemiesList)
            {
                enemy.PrintInfo();
            }
        }


    }
}
