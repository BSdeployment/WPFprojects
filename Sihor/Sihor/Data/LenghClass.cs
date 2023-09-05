using Sihor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihor.Data
{
    public class LenghClass             // פרטי המידע עבור מידות אורך בתורה בנוסף פונקציה המחזירה את כל הרשימה
    {
        public double finger { get; set; }     //שיעור אגודל
        public LenghClass(double finger)
        {
            this.finger = finger;
        }

        public DetailsShior Finger             // אגודל
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "אגודל";
                detailsShior.numbers = finger;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "יסוד המידה לכל דיני התורה, וממנו ילמדו שאר מידות האורך השטח ועוד. בנוסף נוגע לכמה דיני התורה ששיעורם באצבעות, בין היתר גם דיני טומאה וטהרה.";
                return detailsShior;
            }

        }

        //שיעור הטפח

        public DetailsShior Tefach
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "טפח";
                detailsShior.numbers = finger * 4;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "מדה יסודית להרבה הלכות, כגון רשויות שבת, שיעורי מצווה כגון לולב הדס וסוכה, ועוד רבים.";
               return detailsShior;
            }
          
        }

       
        
        
        
        
        public DetailsShior Zeret  //שיעור הזרת )חצי אמה)
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "זרת";
                detailsShior.numbers = finger * (4 * 6) / 2;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "נוגע לרבים מדיני התורה, בעיקר במידות שבמשכן ובכלי המקדש";
                return detailsShior;
            }
        }


        public DetailsShior Ama  //שיעור האמה
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "אמה";
                detailsShior.numbers = finger * (4 * 6);
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "נוגע לדיני תורה רבים כגון שבת, עירובין, סוכה ועוד ";
                return detailsShior;
            }
        }

        public DetailsShior Kane  //שיעור הקנה (שש אמות)
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "קנה";
                detailsShior.numbers = finger * (4 * 6) * 6;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שיעור זה עיקרו מופיע בנביא יחזקאל, ולרוב הפוסקים שיעורו שש אמות";
                return detailsShior;
            }
           
        }

        public DetailsShior Mil  //שיעור מיל
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "מיל";
                detailsShior.numbers = finger * (4 * 6 * 2000);
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "נוגע בעיקר לדיני עירובין, יציאה מחוץ לתחום, ועוד. וכן לעניין מגילה כגון ערים הסמוכות בתוך שיעור מיל.";
                return detailsShior;
            }
        }

        public DetailsShior Ris  //שיעור ריס אחד משבעה וחצי במיל
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "ריס";
                detailsShior.numbers = finger * (4 * 6 * 2000) / 7.5;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שיעור זה נוגע לכמה הלכות שנאמר בהם לשון ראייה שיש בה פגיעה כגון \"כי תראה חמור שנאך רובץ תחת משאו\" ";
                return detailsShior;
            }  
        }




        public DetailsShior Parsat  //שיעור פרסה
        {
            get
            {
                DetailsShior detailsShior = new();
                detailsShior.Titles = "פרסה";
                detailsShior.numbers = finger * (4 * 6 * 2000 * 4);
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שיעור זה משמש בכמה סוגיות בין היתר בחישובי זמנים כפי שיתבאר, וכן לעניין תפילת הדרך, ועוד.  ";
                return detailsShior;
            }
        }

        public string Sum(double res)
        {
            string result ;
            if(res<= 99)
            {
                result = string.Format("סמ {0}",res.ToString("0.00"));
            }
            else
            {
                res = res / 100;
                result  = string.Format("מטר {0}", res.ToString("0.00"));
            }
            return result;
        }


      

        public List<DetailsShior> GetAllDetailsShior()
        
        {

            List<DetailsShior> mylist = new List<DetailsShior>();
            mylist.Add(Finger);
            mylist.Add(Tefach);
            mylist.Add(Zeret);
            mylist.Add(Ama);
            mylist.Add(Kane);
            mylist.Add(Ris);
            mylist.Add(Mil);
            mylist.Add(Parsat);

            return mylist;
        }



    }
}
