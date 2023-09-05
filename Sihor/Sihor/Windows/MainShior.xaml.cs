using Sihor.UserControler;
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
using System.Windows.Shapes;

namespace Sihor.Windows
{
    /// <summary>
    /// Interaction logic for MainShior.xaml
    /// </summary>
    public partial class MainShior : Window
    {
        Color mycolor;
        public MainShior()
        {
            InitializeComponent();
           

        }
        
        
       
        private void txtnavi_MouseDown(object sender, RoutedEventArgs e)
        {
            ChangeColor();
            TextBlock text = (TextBlock)sender;
            int id = int.Parse(text.Uid);
            switch(id)
            {
                case 1:
                    AlignUserControl.Children.Clear();
                    LenghWindow lenghWindow = new();
                   text.FontWeight = FontWeights.Bold;
                    text.Foreground = Brushes.Blue;
                    text.FontSize = 13;
                    AlignUserControl.Children.Add(lenghWindow);
                  
                    break;
                case 2:
                    AlignUserControl.Children.Clear();
                    text.FontWeight = FontWeights.Bold;
                    text.Foreground = Brushes.Blue;
                    text.FontSize = 13;
                    NefachWindow nefachWindow = new();
                    AlignUserControl.Children.Add(nefachWindow);
                  
                    break;
                case 3:
                    AlignUserControl.Children.Clear();
                    text.FontWeight = FontWeights.Bold;
                    text.Foreground = Brushes.Blue;
                    text.FontSize = 13;
                    SetachWindow setachWindow = new();
                    AlignUserControl.Children.Add(setachWindow);
                  
                    break; 
                case 4:
                    AlignUserControl.Children.Clear();
                    text.FontWeight = FontWeights.Bold;
                    text.Foreground = Brushes.Blue;
                    text.FontSize = 13;
                   MatbeaWindow matbea = new();
                    AlignUserControl.Children.Add(matbea);
                  
                    break;

            }
        }
        public void ChangeColor()
        {
            txtlengh.Foreground = txtshetach.Foreground = txtmatbea.Foreground = txtnefach.Foreground = Brushes.Black;
            txtlengh.FontWeight = txtshetach.FontWeight = txtmatbea.FontWeight =  txtnefach.FontWeight = FontWeights.Regular;
            txtlengh.FontSize = txtshetach.FontSize =  txtnefach.FontSize = txtmatbea.FontSize = 12;
            
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnminimazed_Click(object sender, RoutedEventArgs e)
        {
           this.WindowState= WindowState.Minimized;
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new();
            main.Show();
            this.Close();
        }

        private void recdock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) { this.DragMove(); }
        }
    }
}
