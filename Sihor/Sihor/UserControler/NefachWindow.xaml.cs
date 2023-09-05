using Sihor.Data;
using Sihor.Windows;
using Sihor.Model;
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
    /// Interaction logic for NefachWindow.xaml
    /// </summary>
    public partial class NefachWindow : UserControl
    {
        public NefachWindow()
        {
            InitializeComponent();
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

        private void cmbShitot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = cmbShitot.SelectedIndex;


            switch (index)
            {
                case 0:   //שיטת החזו"א
                    txtnote.Text = "לשיטת החזוא (כפי שלומד הקהילות יעקב בשיטתו) שיעור האגודל הינו 2.4 סמ ולפי שיעור זה יתחשבו שאר מדות הנפח. \r\nיש שהחמירו מעיקר הדין כשיטת החזון איש ויש שחששו לו בדאורייתא ויש שאין חוששין לו כלל.\r\n";
                    listshior.DataContext = detailsShiors(2.4);
                    listshior.ItemsSource = detailsShiors(2.4);
                    break;
                case 1:   //שיטת הגר"ח נאה
                    txtnote.Text = "לשיטת הגאון ר חיים נאה שיעור האגודל הוא 2 סמ. רבים נקטו כמותו מעיקר הדין, וכאמור יש שפסקו או שחששו לשיטת החזון איש.";
                    listshior.DataContext = detailsShiors(2);
                    listshior.ItemsSource = detailsShiors(2);
                    break;
                case 2:   //שיטה לבחירה
                    txtnote.Text = "שיעורי מדות הנפח נגזרים מגודל האגודל, יש להזין מספרים בלבד. (הטווח הוא בין 1.9 סמ עד 3.1)";
                    if (txtCustomValue.Text.Trim().Length
                        > 0)
                    {
                        listshior.DataContext = detailsShiors(custom(txtCustomValue.Text));
                        listshior.ItemsSource = detailsShiors(custom(txtCustomValue.Text));
                    }


                    break;
            }
        }
        public List<DetailsShior> detailsShiors(double finger)
        {

            NefachClass lengh = new NefachClass(finger);

            List<DetailsShior> mylist = new List<DetailsShior>();
           
            mylist.Add(lengh.Revit);
            mylist.Add(lengh.Beicha); 
            mylist.Add(lengh.Cezait);
            mylist.Add(lengh.Log);
            mylist.Add(lengh.Kav);
            mylist.Add(lengh.Seaa);
            mylist.Add(lengh.Esaron);
            mylist.Add(lengh.Efa);
            mylist.Add(lengh.Letech);
            mylist.Add(lengh.Coor);
            
            
          

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

      

        private void btncalnef_Click(object sender, RoutedEventArgs e)
        {
            NefachSum nefachSum = new NefachSum();
            Calcultor calcultor = new Calcultor("נפח", nefachSum.sums);
            calcultor.Show();
        }
    }
}
