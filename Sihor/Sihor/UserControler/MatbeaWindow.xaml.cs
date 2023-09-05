using Sihor.Data;
using Sihor.Matbea;
using Sihor.Model;
using Sihor.Windows;
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

namespace Sihor.UserControler
{
    /// <summary>
    /// Interaction logic for MatbeaWindow.xaml
    /// </summary>
    public partial class MatbeaWindow : UserControl
    {
        public MatbeaWindow()
        {
            InitializeComponent();
            cmbseora.IsEnabled = false;
            cmbDerham.IsEnabled = false;
            txtdolar.Text = MySetting.Default.dolar.ToString();
            txtgoldon.Text = MySetting.Default.gold.ToString();
            txtsilveron.Text = MySetting.Default.silver.ToString();
        }

        private void txtseaarch_KeyUp(object sender, KeyEventArgs e)
        {
            if (listshior.ItemsSource != null)
            {
                CollectionView View = (CollectionView)CollectionViewSource.GetDefaultView(listshior.ItemsSource);      // ביצוע הפעולה על ידי פילטר לליסט ויו עצמו
                                                                                                                       // הדבר מתבצע על ידי פונקציה בוליאנית שמחזיר אמת אם הערך מתחיל בטקסט שנבחר בתיבת הטקסט בס"ד
                View.Filter = filters;

            }


        }
        private bool filters(object item)
        {
            DetailsShior deta = new();
            if (string.IsNullOrEmpty(txtseaarch.Text.Trim()))
                return true;
            else
            {
                return (item as DetailsShior).Titles.StartsWith(txtseaarch.Text);
            }
        }



        private void btncalculator_Click(object sender, RoutedEventArgs e)
        {
            MatbeaSumResult matbeaSumResult = new MatbeaSumResult();
            Calcultor calcultor = new Calcultor("מטבעות",matbeaSumResult.detailsForSums);
            calcultor.cmbshitot.Visibility = Visibility.Hidden;
            calcultor.txttoday.Text = "לפי משקל";
           
          
            
            calcultor.Show();
        }

        private void txtCustomValue_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void rbtSeora_Checked(object sender, RoutedEventArgs e)
        {

            if (rbtDerham.IsChecked == true)
            {
                cmbseora.IsEnabled = false;
                cmbDerham.IsEnabled = true;
                if(cmbDerham.SelectedItem== null)
                {
                    return;
                }
                else
                {
                    SumResultDerham();
                }


            }
            if (rbtSeora.IsChecked == true)
            {
                cmbseora.IsEnabled = true;
                cmbDerham.IsEnabled = false;
                if (cmbseora.SelectedItem == null)
                    return;
                else
                {
                    SumResultSeora();
                }
            }

        }

        private void btnupdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateMatbea updateMatbea = new();
            updateMatbea.dolar = double.Parse(txtdolar.Text);
            updateMatbea.silver = double.Parse(txtsilveron.Text);
            updateMatbea.gold = double.Parse(txtgoldon.Text);
            updateMatbea.ShowDialog();

            if (updateMatbea.DialogResult == true)
            {
                this.txtdolar.Text = updateMatbea.dolar.ToString().Trim();
                this.txtsilveron.Text = updateMatbea.silver.ToString().Trim();
                this.txtgoldon.Text = updateMatbea.gold.ToString().Trim();

                //update setting file
                MySetting.Default.dolar = double.Parse(txtdolar.Text);
                MySetting.Default.silver = double.Parse(txtsilveron.Text);
                MySetting.Default.gold = double.Parse(txtgoldon.Text);

                MySetting.Default.Save();

                if(cmbDerham.IsEnabled == true)
                {
                    if(cmbDerham.SelectedItem!=null)
                    {
                        SumResultDerham();
                    }
                }
                else if(cmbseora.IsEnabled == true)
                {
                    if(cmbseora.SelectedItem!=null)
                    {
                        SumResultSeora();
                    }
                }

               

            }
        }

        private void cmbseora_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.Name == "cmbseora")
            {
                SumResultSeora();
            }
            if(comboBox.Name == "cmbDerham")
            {
                SumResultDerham();
            }

           
        }
        private void SumResultSeora()
        {
            double _dolar = 0;
            double _silver = 0;
            double _gold = 0;



            try
            {
                _dolar = double.Parse(txtdolar.Text);
                _silver = double.Parse(txtsilveron.Text);
                _gold = double.Parse(txtgoldon.Text);
            }
            catch
            {
                MessageBox.Show("שגיאה, יתכן שהוזנו ערכים שגויים על ידי המשתמש");
            }

            MatbeaSumGram matbeaSumGram = new(_dolar, _silver, _gold);
            double resultgold = matbeaSumGram.GetGram("זהב");
            double resultsilver = matbeaSumGram.GetGram("כסף");
           
                double gram = 0;
                switch (cmbseora.SelectedIndex)
                {
                    case 0:
                        gram = 0.044;
                        break;
                    case 1:
                        gram = 0.044;
                        break;
                    case 2:
                        double res = 0;
                        try
                        {
                            res = double.Parse(txtcustomseora.Text);
                        }
                        catch
                        {
                            MessageBox.Show("יש להזין בשדה זו מספרים בלבד");
                        }

                        gram = res;
                        break;
                }

                MatbeaSeora matbeaSeora = new(gram, resultsilver, resultgold);


                List<DetailsShior> details = new List<DetailsShior>
                {
                    matbeaSeora.Pruta,
                    matbeaSeora.isar,
                    matbeaSeora.pundion,
                    matbeaSeora.Maa,
                    matbeaSeora.Dinnar,
                    matbeaSeora.ShekelTalmod,
                    matbeaSeora.Sela,
                    matbeaSeora.DinnarZahav,
                    matbeaSeora.ShekelZahav,
                    matbeaSeora.Darcamon

                };
                listshior.DataContext = details;
                listshior.ItemsSource = details;
            
        }

        private void SumResultDerham()
        {
            double _dolar = 0;
            double _silver = 0;
            double _gold = 0;



            try
            {
                _dolar = double.Parse(txtdolar.Text);
                _silver = double.Parse(txtsilveron.Text);
                _gold = double.Parse(txtgoldon.Text);
            }
            catch
            {
                MessageBox.Show("שגיאה, יתכן שהוזנו ערכים שגויים על ידי המשתמש");
            }

            MatbeaSumGram matbeaSumGram = new(_dolar, _silver, _gold);
            double resultgold = matbeaSumGram.GetGram("זהב");
            double resultsilver = matbeaSumGram.GetGram("כסף");

            double gram = 0;
            switch (cmbDerham.SelectedIndex)
            {
                case 0:
                    gram = 2.8;
                    break;
                case 1:
                    gram = 2.9;
                    break;
                case 2:
                    gram = 3;
                    break;
                case 3:
                    gram = 3.1;
                    break; 
                case 4:
                    gram = 3.2;
                    break;
                case 5:
                    double res = 0;
                    try
                    {
                        if(cmbseora.IsEnabled == true)
                        res = double.Parse(txtcustomseora.Text);
                        if(cmbDerham.IsEnabled == true)
                            res = double.Parse(txtCustomValue1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("יש להזין בשדה זו מספרים בלבד");
                    }

                    gram = res;
                    break;
            }

            MatbeaDerhem matbeaDerhem = new(gram, resultsilver, resultgold);


            List<DetailsShior> details = new List<DetailsShior>
                {
                   matbeaDerhem.Pruta,
                    matbeaDerhem.isar,
                    matbeaDerhem.pundion,
                    matbeaDerhem.Maa,
                    matbeaDerhem.Dinnar,
                    matbeaDerhem.ShekelTalmod,
                    matbeaDerhem.Sela,
                    matbeaDerhem.DinnarZahav,
                    matbeaDerhem.ShekelZahav,
                    matbeaDerhem.Darcamon

                };
            listshior.DataContext = details;
            listshior.ItemsSource = details;

        }
    }
}
