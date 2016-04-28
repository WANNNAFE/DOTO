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
        double a, b, c;
        double f(double x)
            {
                return Convert.ToDouble(TextBox11.Text)*Math.Pow(x,4)+Convert.ToDouble(TextBox12.Text)*Math.Pow(x,3)+Convert.ToDouble(TextBox13.Text)*Math.Pow(x,2)+Convert.ToDouble(TextBox14.Text)*x+Convert.ToDouble(TextBox15.Text);
            }
         double findRoot(double a, double b, double e)
            {
                double x;
                x = a - ((b - a) * f(a)) / (f(b) - f(a));
                while(Math.Abs(f(x)) > e)
                {
                    x = a - ((b - a) * f(a)) / (f(b) - f(a));
                    if ((f(x) * f(a)) < 0) x = b; 
                    if (f(x)*f(b)<0) a = x;
                  //  a = b - ((b - a) * f(b))/(f(b) - f(a));
                  //  b = a - ((a - b) * f(a))/(f(a) - f(b));
                }
                return x;
            }

        public MainWindow()
         {

             InitializeComponent();
             {
 
             }
         }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            a = Convert.ToDouble(TextBox1.Text);
            b = Convert.ToDouble(TextBox2.Text);
            c = Convert.ToDouble(TextBox3.Text);
            TextBlock1.Text = Convert.ToString(Convert.ToInt64(findRoot(a, b, c) / c) * c);// + " " + Convert.ToString(a) + " " + Convert.ToString(b);
        }
    }
}
