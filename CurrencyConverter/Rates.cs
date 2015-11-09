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
        public int EUR { get; set; }
        //US Dollar
        public int USD { get; set; }
        //Canadian Dollar
        public int CAD { get; set; }
        //Great British Pound
        public int GBP { get; set; }
        //Chinese Yen
        public int CNY { get; set; }
        //Japanese Yen
        public int JPY { get; set; }
    }
}
