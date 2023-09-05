using Sihor.Data;
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
using System.Windows.Shapes;

namespace Sihor.Windows
{
    /// <summary>
    /// Interaction logic for Calcultor.xaml
    /// </summary>
    public partial class Calcultor : Window
    {
        double result;
        public string TitleWin { get; set; }
        public List<DetailsForSum> detailsForSums { get; set; }

       List<DetailsShior> detailsShiors = new List<DetailsShior>();




        public Calcultor(string title,List<DetailsForSum> list)
        {
            InitializeComponent();
          this.txttitle.Text = title;
            this.detailsForSums = list;
        
           
            //combo box 1
            cmbonevalue.DataContext = detailsForSums;
            cmbonevalue.ItemsSource = detailsForSums;
            //combobox 2
            cmbtwovalue.DataContext = detailsForSums;
            cmbtwovalue.ItemsSource = detailsForSums;
           
        
           





        }




       

       






        private void dragwindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left) { this.DragMove(); }
        }

        private void btnclose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void cmbtwovalue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbonevalue.SelectedItem != null) 
            
            {
                DetailsForSum res = (DetailsForSum)cmbonevalue.SelectedItem;
                DetailsForSum res2 = (DetailsForSum)cmbtwovalue.SelectedItem;
                if (txtnumber.Text == null || txtnumber.Text == "")
                {
                     result = res.numberSum / res2.numberSum;
                    string resultstring = res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                    txtresultcast.Text = resultstring;
                }
                else
                {
                    try
                    {
                        double number = double.Parse(txtnumber.Text.Trim());
                         result = res.numberSum * number / res2.numberSum;


                        string resultstring = txtnumber.Text + " " + res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                        txtresultcast.Text = resultstring;

                    }
                    catch
                    {
                        MessageBox.Show("שים לב שיש להזין מספרים בלבד");
                    }
                }
                GetSshitat();

            }

           

        }

        private void cmbonevalue_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbtwovalue.SelectedItem != null)

            {
                DetailsForSum res = (DetailsForSum)cmbonevalue.SelectedItem;
                DetailsForSum res2 = (DetailsForSum)cmbtwovalue.SelectedItem;
                if (txtnumber.Text == null || txtnumber.Text == "")
                {
                     result = res.numberSum / res2.numberSum;
                    string resultstring = res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                    txtresultcast.Text = resultstring;
                }
                else
                {
                    try
                    {
                        double number = double.Parse(txtnumber.Text.Trim());
                         result = res.numberSum * number / res2.numberSum;
                        string resultstring = txtnumber.Text + " " + res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                        txtresultcast.Text = resultstring;

                    }
                    catch
                    {
                        MessageBox.Show("שים לב שיש להזין מספרים בלבד");
                    }
                }
                GetSshitat();
            }
            
        }

        private void txtnumber_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (cmbtwovalue.SelectedItem != null && cmbonevalue.SelectedItem !=null)

            {
                DetailsForSum res = (DetailsForSum)cmbonevalue.SelectedItem;
                DetailsForSum res2 = (DetailsForSum)cmbtwovalue.SelectedItem;
                if (txtnumber.Text == null || txtnumber.Text == "")
                {
                     result = res.numberSum / res2.numberSum;
                    string resultstring = res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                    txtresultcast.Text = resultstring;
                }
                else
                {
                    try
                    {
                        double number = double.Parse(txtnumber.Text.Trim());
                        result = res.numberSum * number / res2.numberSum;
                       
                        string resultstring = txtnumber.Text + " " + res.Name + " הוא " + result.ToString(GetTypeForRes(result)) + " " + res2.Name;
                        txtresultcast.Text = resultstring;

                    }
                    catch
                    {
                        MessageBox.Show("שים לב שיש להזין מספרים בלבד");
                    }
                }
                GetSshitat();
            }
          

        }

        public string GetSum(double number)               //חישוב תוצאות ההמרה 
        {
            string res = "";
            if (txttitle.Text == "אורך")
            {
                if (number <= 99)
                {
                    res = number.ToString("0.00") + " " + "סמ";

                }
                else if (number >= 99 && number < 99999)
                {
                    number = number / 100;
                    res = number.ToString(GetTypeForRes(number)) + " " + "מטר";

                }
                else
                {
                    number = number / 100000;
                    res = number.ToString(GetTypeForRes(number)) + " " + "קמ";
                }
            }
            else if (txttitle.Text == "שטח")
            {
                if (number <= 999)
                {
                    res = number.ToString("0.00") + " " + "מטר רבוע";

                }
                else
                {
                    number = number / 1000;
                    res = number.ToString("0.000") + " " + "דונם";

                }
            }
            else if (txttitle.Text == "נפח")
            {
                if (number <= 9999)
                {
                    res = number.ToString("0.00") + " " + "סמק";

                }
                else
                {
                    number = number / 1000;
                    res = number.ToString("0.00") + " " + "ליטר";

                }

            }

            return res;

        }

        private void cmbshitot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GetSshitat();
       
        }

        public void GetSshitat()         //מחזירה את הערך לפי השיטות השונות


        {
            if (cmbshitot.SelectedItem == null)
                return;
            DetailsForSum details = (DetailsForSum)cmbtwovalue.SelectedItem;
            string? name = details.Name;
            double resShita = 0;
            switch (cmbshitot.SelectedIndex)
            {
                case 0:

                    resShita = GetNumberFromShita(2.4, name!);
                    resShita = resShita * result;
                    break;

                case 1:
                    resShita = GetNumberFromShita(2, name!);
                    resShita = resShita * result;
                    break;

            }

            txtResultToday.Text = GetSum(resShita);
        }
        public double GetNumberFromShita(double finger, string name)
        {
            double res = 0; // משתנה זה נועד לצורך חישוב ומציאת הערך
            if (txttitle.Text == "אורך")
            {
                // מאותחל לפי הצורך מידות אורך שטח וכדו'
                LenghClass lenghClass = new LenghClass(finger);
                List<DetailsShior> myListShioer = lenghClass.GetAllDetailsShior();


                foreach (var item in myListShioer.Where(a => a.Titles == name))
                {
                    res = item.numbers;
                }

               
            }
            else if (txttitle.Text == "שטח")
            {
                ShetachClass shetachClass = new ShetachClass(finger);
                List<DetailsShior> myListShioer = shetachClass.GetAll();


                foreach (var item in myListShioer.Where(a => a.Titles == name))
                {
                    res = item.numbers;
                }
            }
            
            else if (txttitle.Text == "נפח")
            {
                NefachClass nefachClass =  new NefachClass(finger);
                List<DetailsShior> myListShioer = nefachClass.GetAllDetailsShior();


                foreach (var item in myListShioer.Where(a => a.Titles == name))
                {
                    res = item.numbers;
                }
            }
            else if (txttitle.Text == "מטבע")
            {
                NefachClass nefachClass =  new NefachClass(finger);
                List<DetailsShior> myListShioer = nefachClass.GetAllDetailsShior();


                foreach (var item in myListShioer.Where(a => a.Titles == name))
                {
                    res = item.numbers;
                }
            }
            return res;

        }

        public string GetTypeForRes(double numbers)       //פונקציה זו אחראית על סידור נתונים כך שבמספרים שלמים יוצג ללא
            //מספר עשרוני ובמספרים חלקיים יוצג עם ספרה עשרונית פונקציה זו פועלת לתוך פורמט הסטרינג
        {
            
            bool a = int.TryParse(numbers.ToString(), out int b);
            if (a) { return  ""; }
            else return  "0.000";
        }
    }
}
