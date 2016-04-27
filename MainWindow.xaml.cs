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

namespace MetodHord
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        double f(double x)
            {
                return Math.Pow(x,3)-0.2*Math.Pow(x,2)+0.2*x-1.2;
            }
         double findRoot(double a, double b, double e)
            {
                while(Math.Abs(f(b)) > e)
                {
                    a = b - ((b - a) * f(b))/(f(b) - f(a));
                    b = a - ((a - b) * f(a))/(f(a) - f(b));
                }
                return b;
            }

        public MainWindow()
         {

             InitializeComponent();
             {
 
             }
         }
    }
}
