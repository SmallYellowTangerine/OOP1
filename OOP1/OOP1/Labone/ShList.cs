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
        int coordx1=50, coordy1=50, coordx2=80, coordy2=50;

        private void changecoord()
        {
            if (coordx1 < 550)
            {
                coordx1 += 100;
                coordx2 += 100;
            }
            else
            {
                coordx1 = 40;
                coordx2 = 70;
                coordy1 = coordy2 = coordy1 + 100;
            }     
        }

        public void addShape(Canvas canv, Sh1 shape)
        {
            //shape.drawLine(canv, 40, 40, 100, 100);
            shape.drawLine(canv, coordx1, coordy1, coordx2, coordy2);
            changecoord();
        }

        public void addShape(Canvas canv, Sh2 shape)
        {
            //shape.drawTriangle(canv, 150, 40, 250, 40);
            shape.drawTriangle(canv, coordx1, coordy1, coordx2, coordy2);
            changecoord();
        }

        public void addShape(Canvas canv, Sh3 shape)
        {
            //shape.draw4angle(canv, 300, 40, 350, 40);
            shape.draw4angle(canv, coordx1, coordy1, coordx2, coordy2);
            changecoord();
        }

        public void addShape(Canvas canv, Sh4 shape)
        {
            //shape.draw6angle(canv, 450, 40, 480, 40);
            shape.draw6angle(canv, coordx1, coordy1, coordx2, coordy2);
            changecoord();
        }

        public void addShape(Canvas canv, Sh5 shape)
        {
            //shape.draw5angle(canv, 550, 40, 600, 40);
            shape.draw5angle(canv, coordx1, coordy1, coordx2, coordy2);
            changecoord();
        }

        public void addShape(Canvas canv, Sh6 shape)
        {
            //shape.drawStar(canv, 100, 200);
            shape.drawStar(canv, coordx1, coordy1);
            changecoord();
        }

    }
}
