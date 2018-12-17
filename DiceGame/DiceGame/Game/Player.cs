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
        private int diceAmount;
        private int[] dicesPoints;

        public Player (string name, int diceAmount)
        {
            this.name = name;
            this.diceAmount = diceAmount;

            dicesPoints = new int[diceAmount];

        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name} dices points ");
        }

    }
}
