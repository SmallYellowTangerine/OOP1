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
    class Sh4 : Sh3
    {
        public void draw6angle(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {
            drawLine(canv, xcoor1, ycoor1, xcoor2, ycoor2);
            drawLine(canv, xcoor2, ycoor2, xcoor2+30, ycoor2+30);
            drawLine(canv, xcoor2 + 30, ycoor2 + 30, xcoor2, ycoor2+60);
            drawLine(canv, xcoor2, ycoor2 + 60, xcoor1, ycoor1+60);
            drawLine(canv, xcoor1, ycoor1 + 60, xcoor1-30, ycoor1+30);
            drawLine(canv, xcoor1 - 30, ycoor1 + 30, xcoor1, ycoor1);
        }

    }
}
