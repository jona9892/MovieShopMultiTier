﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class ValutaData
    {
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public Rates Rates { get; set; }
    }
}
