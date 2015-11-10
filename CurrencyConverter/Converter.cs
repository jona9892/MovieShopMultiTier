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
        ValutaData valutaData = new ValutaData();
        public string ValutaAPIURL = "http://api.fixer.io/latest?base=DKK";
        public Converter()
        {
            StartupDataLoad();
        }

        private void StartupDataLoad()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync(ValutaAPIURL).Result;
                valutaData = response.Content.ReadAsAsync<ValutaData>().Result;
            }
        }

        public int DkkToEur(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.EUR;
            int result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToUsd(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.USD;
            int result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToGbp(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.GBP;
            int result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToCny(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.CNY;
            int result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToJpy(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.JPY;
            int result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToCad(int dkkAmount)
        {
            double amount = dkkAmount * valutaData.Rates.CAD;
            int result = Convert.ToInt32(amount);
            return result;
        }
    }
}
