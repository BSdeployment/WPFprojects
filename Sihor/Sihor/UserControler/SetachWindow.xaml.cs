using Sihor.Data;
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
    /// Interaction logic for SetachWindow.xaml
    /// </summary>
    public partial class SetachWindow : UserControl
    {
        public SetachWindow()
        {
            InitializeComponent();
        }

        private void cmbShitot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cmbShitot.SelectedIndex;


            switch (index)
            {
                case 0:   //שיטת החזו"א
                    txtnote.Text = "לשיטת החזוא (כפי שלומד הקהילות יעקב בשיטתו) שיעור האגודל הינו 2.4 סמ ולפי שיעור זה יתחשבו שאר מדות השטח. \r\nיש שהחמירו מעיקר הדין כשיטת החזון איש ויש שחששו לו בדאורייתא ויש שאין חוששין לו כלל.\r\n";
                    listshior.DataContext = detailsShiors(2.4);
                    listshior.ItemsSource = detailsShiors(2.4);
                    break;
                case 1:   //שיטת הגר"ח נאה
                    txtnote.Text = "לשיטת הגאון ר חיים נאה שיעור האגודל הוא 2 סמ. רבים נקטו כמותו מעיקר הדין, וכאמור יש שפסקו או שחששו לשיטת החזון איש.";
                    listshior.DataContext = detailsShiors(2);
                    listshior.ItemsSource = detailsShiors(2);
                    break;
                case 2:   //שיטה לבחירה
                    txtnote.Text = "שיעורי מדות השטח נגזרים מגודל האגודל, יש להזין מספרים בלבד. (הטווח הוא בין 1.9 סמ עד 3.1)";
                    if (txtCustomValue.Text.Trim().Length
                        > 0)
                    {
                        listshior.DataContext = detailsShiors(custom(txtCustomValue.Text));
                        listshior.ItemsSource = detailsShiors(custom(txtCustomValue.Text));
                    }


                    break;
            }
        }

        private void txtCustomValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCustomValue.Text.Trim().Length > 0)
            {
                listshior.DataContext = detailsShiors(custom(txtCustomValue.Text));
                listshior.ItemsSource = detailsShiors(custom(txtCustomValue.Text));
            }
            else
            {
                listshior.DataContext = null;
                listshior.ItemsSource = null;
            }
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
        public List<DetailsShior> detailsShiors(double finger)
        {

            ShetachClass shetachClass = new ShetachClass(finger);

            List<DetailsShior> mylist = new List<DetailsShior>();

            mylist.Add(shetachClass.Bsea); 
            mylist.Add(shetachClass.Bsaataim);
            mylist.Add(shetachClass.BetKav);
            mylist.Add(shetachClass.BetRova);
            mylist.Add(shetachClass.BetCoor);
            mylist.Add(shetachClass.BetLetech);




            return mylist;
        }
        public double custom(string costom)
        {
            if (txtCustomValue.Text.Trim().Length > 0)

            {


                try
                {
                    double custom1 = double.Parse(costom);
                    return custom1;
                }
                catch
                {
                    MessageBox.Show("הוזן ערך שגוי. שים לב שיש להזין מספרים בלבד");

                    return 0;
                }
            }
            else
            {
                return 0;
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

        private void btncal_Click(object sender, RoutedEventArgs e)
        {
            SetachSum setachSum =  new SetachSum();
            Calcultor calcultor = new Calcultor("שטח", setachSum.sum);
            calcultor.Show();
        }
    }
}
