using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Labone
{
    class Sh6 :Sh5
    {
        public void drawStar(Canvas canv, int x, int y)
        {
            drawLine(canv, x, y, x + 10, y + 30);
            drawLine(canv, x, y, x - 10, y + 30);

            drawLine(canv, x, y, x + 10, y + 30);
            drawLine(canv, x, y, x - 10, y + 30);

            drawLine(canv, x + 10, y + 30, x+40, y+40);
            drawLine(canv, x - 10, y + 30, x-40, y+40);

            drawLine(canv, x+40, y+40, x + 10, y + 50);
            drawLine(canv, x-40, y+40, x - 10, y + 50);

            drawLine(canv, x + 10, y + 50, x, y + 80);
            drawLine(canv, x - 10, y + 50, x, y + 80);

        }

    }
}
