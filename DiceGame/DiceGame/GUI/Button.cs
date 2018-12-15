using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private bool isActive = false;
        private Frame notActiveFrame;
        private TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {

            activeFrame = new Frame(x, y, width, height, '+');
            notActiveFrame = new Frame(x, y, width, height, '-');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);

        }

        public void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }

        public void SetActive()
        {
            isActive = true;
        }

        internal void SetInActive()
        {
            isActive = false;
        }
    }
}
