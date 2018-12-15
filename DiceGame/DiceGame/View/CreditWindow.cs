using DiceGame.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.View
{
    class CreditWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;
        private List<string> text = new List<string>();

        public CreditWindow() : base(20, 2, 40, 22, '@')
        {

            text.Add("Credits");

            creditTextBlock = new TextBlock(30, 10, 20, text);

            backButton = new Button(30, 18, 18, 5, "Back");
            backButton.SetActive();
            //Render();
        }

        public override void Render()
        {
            base.Render();
            creditTextBlock.Render();
            backButton.Render();

        }

        public void removeCreditWindow()
        {
            Console.Clear();
        }
    }
}
