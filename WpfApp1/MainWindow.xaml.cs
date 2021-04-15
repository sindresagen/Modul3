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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _count = 0;
        private int _countUpgrade = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _count++;
            CountLabel.Content = "Du har klikket " + _count + " ganger.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_count < 10) return;
            _count -= 10;
            _count += _countUpgrade;
        }
    }
}
