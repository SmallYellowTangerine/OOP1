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

            Sh1 line1 = new Sh1();
            line1.drawLine(myCanvas, 40, 40, 100, 100);
            Sh2 triangle1 = new Sh2();
            triangle1.drawTriangle(myCanvas, 150, 40, 250, 40);
            Sh3 some4angle1 = new Sh3();
            some4angle1.draw4angle(myCanvas, 300, 40, 350, 40);
            
        }

        

       
    }
}
