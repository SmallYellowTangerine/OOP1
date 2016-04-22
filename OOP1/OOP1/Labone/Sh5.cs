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
    class Sh5 : Sh4 
    {
        public void draw5angle(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {
            draw4angle(canv, xcoor1, ycoor1, xcoor2, ycoor2);
            drawTriangle(canv, xcoor1+30, ycoor1+30, xcoor2+30, ycoor2+30);

            drawWhite(canv, xcoor1 + 30, ycoor1 + 30, xcoor2 + 30, ycoor2 + 30); 
        }

    }
}
