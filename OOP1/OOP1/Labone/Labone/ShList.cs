using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labone
{
    class ShList
    {
        public void addShape(Canvas canv, Sh1 shape)
        {
            //Sh1 line1 = new Sh1();
            shape.drawLine(canv, 40, 40, 100, 100);
        }

        public void addShape(Canvas canv, Sh2 shape)
        {
            //Sh2 triangle1 = new Sh2();
            shape.drawTriangle(canv, 150, 40, 250, 40);
        }

        public void addShape(Canvas canv, Sh3 shape)
        {
            //Sh3 some4angle1 = new Sh3();
            shape.draw4angle(canv, 300, 40, 350, 40);
        }

        public void addShape(Canvas canv, Sh4 shape)
        {
            //Sh4 some6angle1 = new Sh4();
            shape.draw6angle(canv, 450, 40, 480, 40);
        }

        public void addShape(Canvas canv, Sh5 shape)
        {
            //Sh5 some5angle1 = new Sh5();
            shape.draw5angle(canv, 550, 40, 600, 40);
        }

        public void addShape(Canvas canv, Sh6 shape)
        {
            //Sh6 star1 = new Sh6();
            shape.drawStar(canv, 100, 200);
        }

    }
}
