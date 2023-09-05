using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sihor.Model;

namespace Sihor.Data
{
    public class MatbeaSumResult
    { 
        public List<DetailsForSum> detailsForSums = new List<DetailsForSum>{
            new DetailsForSum{Name = "פרוטה", numberSum =  1,Title = "כסף" },
            new DetailsForSum{Name = "איסר", numberSum =  8,Title = "כסף" },
            new DetailsForSum{Name = "פונדיון", numberSum =  16,Title = "כסף" },
            new DetailsForSum{Name = "מעה", numberSum =  32,Title = "כסף" },
            new DetailsForSum{Name = "דינר כסף", numberSum =  192,Title = "כסף" },
            new DetailsForSum{Name = "שקל תלמודי", numberSum =  384,Title = "כסף" },
            new DetailsForSum{Name = "סלע", numberSum =  768,Title = "כסף" },
            new DetailsForSum{Name = "דינר זהב", numberSum =  384,Title = "זהב" },
            new DetailsForSum{Name = "שקל", numberSum =  768,Title = "זהב" },
            new DetailsForSum{Name = "דרכמון", numberSum =  96,Title = "זהב" }
        };
    }
}
