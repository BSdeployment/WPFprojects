using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sihor.Services
{
   public class SumServices
    {
        public SumServices()
        { 
        
        }
        public double SumToMeter(double value)   //לחלק כל מספר שמתקבל בס"מ למטר
        {
            return value / 100;
        }
    }
}
