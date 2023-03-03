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

namespace VAGA2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var STZ = new STZ();
            STZ.Show();
            this.Close();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var SIZ = new SIZ();
            SIZ.Show();
            this.Close();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            var Win2 = new Win2();
            Win2.Show();
            this.Close();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            var Win3 = new Win3();
            Win3.Show();
            this.Close();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            var Win3 = new Win3();
            Win3.Show();
            this.Close();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            var Win3 = new Win3();
            Win3.Show();
            this.Close();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            var Win4 = new Win4();
            Win4.Show();
            this.Close();
        }
    }
}
