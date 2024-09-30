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

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Update1()
        {
            //Comment
            //Comment
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double upperbound = Convert.ToDouble(tbUpperBound.Text);
            double lowerbound = Convert.ToDouble(tbLowerBound.Text);
            int partcount = Convert.ToInt16(tbPartCount.Text);
            IntegrateRect resh = new IntegrateRect();
            IntegrateTrap trap = new IntegrateTrap();
            if(cmbIntegralType.SelectedIndex == 0)
            {
                ansRect.Text = Convert.ToString(resh.Resh(F, upperbound, lowerbound, partcount));
            }
            else
            {
                ansRect.Text = Convert.ToString(trap.Resh(F, upperbound, lowerbound, partcount));
            }            
        }

        // Функция f(x)
        private static double F(double x)
        {
            return 7 * x - Math.Log(7 * x) + 8;
        }
    }
}
