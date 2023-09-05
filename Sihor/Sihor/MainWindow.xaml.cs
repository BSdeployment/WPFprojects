using Sihor.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Sihor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           //Thread.Sleep(3000);
            InitializeComponent();
            
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnresize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnenter_Click(object sender, RoutedEventArgs e)
        {
            MainShior mainShior = new MainShior();
            mainShior.Show();
            this.Close();
        }

        private void dockmain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) { this.DragMove(); }
        }
    }
}
