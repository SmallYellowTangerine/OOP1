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
    class Sh1
    {
        public void drawLine(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {
            Line line = new Line();
            line.Stroke = System.Windows.Media.Brushes.Black;
            line.X1 = xcoor1;
            line.Y1 = ycoor1;
            line.X2 = xcoor2;
            line.Y2 = ycoor2;
            canv.Children.Add(line);

        }
        
        


    }
}
