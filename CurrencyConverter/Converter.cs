using System;
using System.Net.Http;

namespace CurrencyConverter
{
    public class Converter
    {
        public string ValutaAPIURL = "http://api.fixer.io/latest?base=DKK";
        public ValutaData valutaData = new ValutaData();

        public Converter()
        {
            StartupDataLoad();
        }

        private void StartupDataLoad()
        {
            using (var client = new HttpClient())
            {
                var response =
                    client.GetAsync(ValutaAPIURL).Result;
                valutaData = response.Content.ReadAsAsync<ValutaData>().Result;
            }
        }

        public int DkkToEur(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.EUR;
            var result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToUsd(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.USD;
            var result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToGbp(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.GBP;
            var result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToCny(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.CNY;
            var result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToJpy(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.JPY;
            var result = Convert.ToInt32(amount);
            return result;
        }

        public int DkkToCad(int dkkAmount)
        {
            var amount = dkkAmount*valutaData.Rates.CAD;
            var result = Convert.ToInt32(amount);
            return result;
        }
    }
}