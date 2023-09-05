using Sihor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihor.Data
{
   public class ShetachClass
    {
        double finger;
        double ama;
        public ShetachClass(double finger)
        {
            this.finger = finger;
            this.ama = finger*24;
        }
        public DetailsShior Bsea         //בית סאה
        {
            get
            {
                DetailsShior detailsShior= new DetailsShior();
                detailsShior.Titles = "בית סאה";
                detailsShior.numbers = (50*ama)*(50*ama)/10000;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "בית סאה מוזכר במשניות ובגמרות לכמה דינים  כגון כלאים, ושביעית ועוד. ";
                return detailsShior;
            }
        }
        public DetailsShior Bsaataim         //בית סאתיים
        {
            get
            {
                DetailsShior detailsShior= new DetailsShior();
                detailsShior.Titles = "בית סאתיים";
                detailsShior.numbers = (50*ama)*(100*ama)/10000;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "נוגע לכמה הלכות ביניהם בהלכות עירובין - אם שטח כזה לא הוקף לדירה אין מטלטלין בו אלא בד' אמות.";
                return detailsShior;
            }
        }

        public DetailsShior BetKav         //בית קב
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "בית קב";
                detailsShior.numbers = (50 * ama) * (50 * ama) / 10000/6;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "שישית בית סאה מוזכר  בגמרא כמה פעמים והחישוב כאן לדעת הרמבם כפי שנכתב.  ";
                return detailsShior;
            }
        }
        public DetailsShior BetRova         //בית רובע
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "בית רובע";
                detailsShior.numbers = (50 * ama) * (50 * ama) / 10000/6/4;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "בהלכות כלאים מבואר שהוא השיעור שיש להרחיק בין תבואה לתבואה לעניין כלאים, ונוגע לעוד דינים כגון פאה ועוד. ";
                return detailsShior;
            }
        }
        public DetailsShior BetCoor         //בית כור
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "בית כור";
                detailsShior.numbers = (100 * ama) * (50 * ama) *15/10000;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "יש להדגיש כאן שכפי שיתבאר בקובץ המידע, לדעת חלק מן הראשונים בין כור המוזכר בתורה שונה מבית כור המוזכר במשנה. ";
                return detailsShior;
            }
        }
        public DetailsShior BetLetech         //בית לתך
        {
            get
            {
                DetailsShior detailsShior = new DetailsShior();
                detailsShior.Titles = "בית לתך";
                detailsShior.numbers = (100 * ama) * (50 * ama) *15/2/10000;
                detailsShior.result = Sum(detailsShior.numbers);
                detailsShior.Description = "חצי מבית כור מוזכר במסכת בבא בתרא לגבי מכירה , וכן במסכת ערכין לגבי הקדשות ועוד. ";
                return detailsShior;
            }
        }



        public string Sum(double res)
        {
            string result;
            if (res <= 999)
            {
                result = res.ToString("0.00")+" מטר ר' ";
            }
            else
            {
                res = res / 1000;
                result = res.ToString("0.000") + " דונם ";
            }
            return result;
        }
        public List<DetailsShior> GetAll()
        {
            List<DetailsShior> list = new List<DetailsShior>();
            list.Add(Bsea);
            list.Add(BetLetech);
            list.Add(BetCoor);
            list.Add(BetRova);
            list.Add(BetKav);
            list.Add(Bsaataim);
            return list;
        }

    }
}
