using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    /// <summary>
    /// This class has all the rates relative to the Danish Krone.
    /// so if the rate below is 0.10 it means you can get 10 of the foreign currency for 1 DKK.
    /// </summary>
    public class Rates
    {
        //Euro
        public double EUR { get; set; }
        //US Dollar
        public double USD { get; set; }
        //Canadian Dollar
        public double CAD { get; set; }
        //Great British Pound
        public double GBP { get; set; }
        //Chinese Yen
        public double CNY { get; set; }
        //Japanese Yen
        public double JPY { get; set; }
    }
}
}
