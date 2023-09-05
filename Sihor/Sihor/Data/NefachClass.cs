using Sihor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Sihor.Data
{
    public class NefachClass
    {
        double finger;           //שיעור אגודל
       public NefachClass(double finger)
        {
            this.finger = finger;   
        }

        public DetailsShior Finger
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "אגודל";
                detailsShior.numbers = finger;
                detailsShior.result = Sum(detailsShior.numbers);
                return detailsShior;
            }
        } 
        public DetailsShior Revit  //רביעית
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "רביעית";
                detailsShior.numbers = (2*finger) *(2*finger) * (2.7*finger);
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "רביעית של תורה, כגון רביעית יין לנזיר, וכן לגבי טומאת מת לענין דם (עיין פסחים קט א) בנוסף דיני דרבנן רבים, כגון ארבע כוסות, קידוש במקום סעודה, שיעור ברכה אחרונה ועוד קשורים לשיעור רביעית. ";
                return detailsShior;
            }
        }
        
        public DetailsShior Beicha  //ביצה
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "ביצה";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))/3*2;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שיעור כביצה נוגע גם לדיני דאורייתא כגון טומאת אוכלים, וגם לדיני דרבנן כגון אכילה לפני מצווה, נטילת ידים בברכה וכדו'. ";
                return detailsShior;
            }
        } 
        public DetailsShior Cezait  //כזית
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "כזית";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))/3;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "כזית שיעור זה תקף לכל שיעורי אכילה שבתורה, כגון מצה כזית בסוכה, קדשים. וכן לאכילות דרבנן, כגון ברכה אחרונה וכדו' – סתם אכילה בכזית";
                return detailsShior;
            }
        } 
        public DetailsShior Log  //לוג
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "לוג";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))*4;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שיעור יסודי במדת הלח שמשמש גם לענייני מנחות וקדשים, כגון ניסוך היין וכדומה. ";
                
                return detailsShior;
            }
        } 
        public DetailsShior Kav  //קב
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "קב";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))*4*4;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "נוגע לכמה דיני תורה והרבה דיני דרבנן, שימש בעיקר למידת היבש, אך מצינו שהוזכר גם במידת הלח.";
                return detailsShior;
            }
        }
        public DetailsShior Seaa  //סאה
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "סאה";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))*4*4*6;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "מידה יסודית במידות היבש מוזכרת פעמים רבות בשס. ולפי חלק מן הפרשנים מוזכרת גם בתנך.";
                return detailsShior;
            }
        } 
        
        public DetailsShior Efa  //איפה
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "איפה";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))*4*4*6*3;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "מידת היבש מוזכרת אף היא בכמה מקומות";
                return detailsShior;
            }
        }
        public DetailsShior Esaron  //עשרון
        {
            get
            {
                DetailsShior detailsShior  = new DetailsShior();
                detailsShior.Titles = "עשרון";
                detailsShior.numbers = ((2*finger) *(2*finger) * (2.7*finger))*4*4*6*3/10;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שם נוסף הוא גם עומר, מוזכר בתורה - והעומר עשירית האיפה הוא.";
                return detailsShior;
            }
        }
        public DetailsShior Coor  //כור
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "כור";
                detailsShior.numbers = ((2 * finger) * (2 * finger) * (2.7 * finger)) * 4 * 4 * 6*30;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "המידה הגדולה ביותר במידות המוזכר בתורה ובשס";
                return detailsShior;
            }
        } 
        public DetailsShior Letech  //לתך
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "לתך";
                detailsShior.numbers = ((2 * finger) * (2 * finger) * (2.7 * finger)) * 4 * 4 * 6*30/2;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "מוזכר פעם אחת בתנך, ובמשניות ובגמ' כמה פעמים כגון – כור לי בידך, אין לך בידי אלא לתך.";
                return detailsShior;
            }
        }

        public string Sum(double res)
        {
            string result;
            if (res <= 9999)
            {
                result = string.Format("סמק {0}", res.ToString("0.00"));
            }
            else
            {
                res = res / 1000;
                result = string.Format("ליטר {0}", res.ToString("0.00"));
            }
            return result;
        }

        public List<DetailsShior> GetAllDetailsShior()

        {

            List<DetailsShior> mylist = new List<DetailsShior>();
           
            mylist.Add(Cezait);
            mylist.Add(Beicha);
            mylist.Add(Revit);
            mylist.Add(Kav);
            mylist.Add(Log);
            mylist.Add(Efa);
            mylist.Add(Seaa);
            mylist.Add(Coor);
            mylist.Add(Esaron);
            mylist.Add(Letech);

            return mylist;
        }



    }
}
