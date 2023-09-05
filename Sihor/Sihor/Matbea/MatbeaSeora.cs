using Sihor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace Sihor.Matbea
{
    class MatbeaSeora
    {
        private double _Seora;
        double _silvergram;
        double _goldgram;

        public MatbeaSeora(double seora,double silvergram,double goldgram)
        {
            this._Seora = seora;
            this._goldgram= goldgram;
            this._silvergram = silvergram;
        }

        public DetailsShior Pruta          //פרוטה
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "פרוטה";
                detailsShior.Subtitle = "נחושת";
                detailsShior.numbers = _Seora / 2;
                detailsShior.result = ResultString(sum( detailsShior.Subtitle ,detailsShior.numbers)) ;
                detailsShior.Description = " פרוטה = מטבע יסודית להרבה דינים בתורה שתלויים במטבעות, כגון קידושין, גניבה גזילה, קניינים ועוד. משקלה לפי חישוב זה הוא " 
                    + detailsShior.numbers.ToString("0.000") + " " + "גרם";
                return detailsShior;
            }
        }

        public DetailsShior isar          //איסר
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "איסר";
                detailsShior.Subtitle = "נחושת";
                detailsShior.numbers = _Seora * 4;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "מטבע שמוזכר כמה פעמים בתלמוד כגון במסכת קידושין, בבא בתרא ועוד. משקלו לפי חישוב זה הוא"
                    + " " + detailsShior.numbers.ToString("0.000") + " " + "גרם"
                    ;
                return detailsShior;
            }
        }
        public DetailsShior pundion          //פןנדיון
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "פונדיון";
                detailsShior.Subtitle = "נחושת";
                detailsShior.numbers = _Seora * 8;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }
        
        public DetailsShior Maa          //מעה
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "מעה";
                detailsShior.Subtitle = "כסף";
                detailsShior.numbers = _Seora * 16;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }
        public DetailsShior Dinnar          //דינר
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "דינר";
                detailsShior.Subtitle = "כסף";
                detailsShior.numbers = _Seora * 96;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        } 
        public DetailsShior ShekelTalmod          //שקל תלמודי
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "שקל תלמודי";
                detailsShior.Subtitle = "כסף";
                detailsShior.numbers = _Seora * 192;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }
        
        public DetailsShior Sela          //סלע
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "סלע";
                detailsShior.Subtitle = "כסף";
                detailsShior.numbers = _Seora * 384;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }
        
        public DetailsShior DinnarZahav          //דינר זהב
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "דינר";
                detailsShior.Subtitle = "זהב";
                detailsShior.numbers = _Seora * 192;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        } 
        public DetailsShior ShekelZahav          //שקל זהב
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "שקל";
                detailsShior.Subtitle = "זהב";
                detailsShior.numbers = _Seora * 384;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }
        public DetailsShior Darcamon          //דרכמון
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "דרכמון";
                detailsShior.Subtitle = "זהב";
                detailsShior.numbers = _Seora * 48;
                detailsShior.result = ResultString(sum(detailsShior.Subtitle, detailsShior.numbers));
                detailsShior.Description = "";
                return detailsShior;
            }
        }

        private double sum(string subtiitle, double number)   // math for price in shekels
        {
            double result = 0;
            if (subtiitle == "זהב")
            {
                result = number * _goldgram;
            }
            else
            {
                result= number * _silvergram;
            }
            return result;
        }

        public string ResultString(double result)      // return string format result
        {
            return result.ToString("0.00") + " " + "שקל";
        }



        //public List<DetailsShior> AllItem()
        //{
        //    List<DetailsShior> list = new();
        //    list.Add(Pruta);
        //}
       
    }
}
