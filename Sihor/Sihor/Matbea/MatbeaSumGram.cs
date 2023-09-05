using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihor.Matbea
{
    public class MatbeaSumGram
    {
        double dolar;
        double silver;
        double gold;

        public MatbeaSumGram(double dolar,double silve,double gold)
        {
            this.dolar = dolar;
            this.silver = silve;    
                this.gold = gold;
        }


        public double GetGram(string title)           //this function return value of silver or gold gram
        {
            if (title == "כסף")
            {
                double gram = silver / 31.1;
                return gram * dolar;
            }
            else   //gold
            {
                double gram = gold / 31.1;
                return gram * dolar;
            }
        }

    }
}
