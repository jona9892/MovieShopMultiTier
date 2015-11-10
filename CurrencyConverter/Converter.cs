using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Converter
    {
        Rates rates = new Rates();
        public string ValutaAPIURL = "http://api.fixer.io/latest?base=DKK";
        public Converter()
        {
            StartupDataLoad();
        }

        public static void Main(String[] args)
        {
            new Converter();
        }

        private void StartupDataLoad()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://api.fixer.io/latest?base=DKK").Result;
                rates = response.Content.ReadAsAsync<Rates>().Result;
            }
        }

    }
}
