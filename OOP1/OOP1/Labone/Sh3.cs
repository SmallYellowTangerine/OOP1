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
    class Sh3 : Sh2
    {
        public void drawWhite(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {

            Line line = new Line();
            line.Stroke = System.Windows.Media.Brushes.White;
            line.StrokeThickness = 3;
            line.X1 = xcoor1;
            line.Y1 = ycoor1;
            line.X2 = xcoor2;
            line.Y2 = ycoor2;
            canv.Children.Add(line);


        }
        
        public void draw4angle(Canvas canv, int xcoor1, int ycoor1, int xcoor2, int ycoor2)
        {

            drawTriangle(canv, xcoor1, ycoor1, xcoor2, ycoor2);
            drawTriangle(canv, xcoor2, ycoor2, xcoor1+30, ycoor1+30);

            drawWhite(canv, xcoor2, ycoor2, xcoor1 + 30, ycoor1 + 30);            
        }
    }
}
