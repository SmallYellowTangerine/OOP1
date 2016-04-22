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
    class Sh2 : Sh1
    {
        public void drawTriangle(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {

            drawLine(canv, xcoor1, ycoor1, xcoor2, ycoor2);
            drawLine(canv, xcoor2, ycoor2, xcoor1+30, ycoor1+30);
            drawLine(canv, xcoor1 + 30, ycoor1 + 30, xcoor1, ycoor1);
        }
    }
}
