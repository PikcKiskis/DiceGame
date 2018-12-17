using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.Game
{
    class Player
    {
        private string name;
        private List<int> dicesPoints;

        


        public Player(string name, List<int> dicesPoints)
        {
            this.name = name;
            this.dicesPoints = dicesPoints;


        }



        public void PrintInfo()
        {
            Console.WriteLine($"{name} dices: ");
            foreach (var item in dicesPoints)
            {
                Console.WriteLine(item);
            }

        }

        

}
}
