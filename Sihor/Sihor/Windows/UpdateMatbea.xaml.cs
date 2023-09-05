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
    /// Interaction logic for UpdateMatbea.xaml
    /// </summary>
    public partial class UpdateMatbea : Window
    {
        public UpdateMatbea()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void movewin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        public double dolar { get; set; }
        public double silver { get; set; }
        public double gold { get; set; }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
           if(requoired() == false)
            {
                txtreqourd.Visibility = Visibility.Visible;
            }
            else
            {
                DialogResult = true;
            }

           
        }


        private bool requoired()
        {
            if(txtdolar.Text.Trim() == ""||txtgold.Text.Trim() == ""||txtsilver.Text.Trim()=="")
            {
                return false;
            }
            else { return true; }
        }
    }
}
