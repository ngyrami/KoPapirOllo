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

namespace GameMenu
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

        private void KoPapirOllo_Click(object sender, RoutedEventArgs e)
        {
            KoPapirOllo.MainWindow KoPapirOlloWindow = new KoPapirOllo.MainWindow();
            KoPapirOlloWindow.Show();
        }

        private void Snake_Click(object sender, RoutedEventArgs e)
        {
            SnakeWPF.MainWindow SnakeWindow = new SnakeWPF.MainWindow();
            SnakeWindow.Show();
        }
    }
}
