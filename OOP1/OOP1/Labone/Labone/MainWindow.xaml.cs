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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ShList shapesList = new ShList();

            Sh1 line1 = new Sh1();
            Sh2 triangle1 = new Sh2();
            Sh3 some4angle1 = new Sh3();
            Sh4 some6angle1 = new Sh4();
            Sh5 some5angle1 = new Sh5();
            Sh6 star1 = new Sh6();

            shapesList.addShape(myCanvas, line1);
            shapesList.addShape(myCanvas, triangle1);
            shapesList.addShape(myCanvas, some4angle1);
            shapesList.addShape(myCanvas, some5angle1);
            shapesList.addShape(myCanvas, some6angle1);
            shapesList.addShape(myCanvas, star1);
        }

        

       
    }
}
