using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame.GUI
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            border = new Frame(x, y, width, height, borderChar);
        }

        public virtual void Render()
        {
            border.Render();
        }
    }
}
