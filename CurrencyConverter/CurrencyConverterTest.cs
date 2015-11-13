using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CurrencyConverter
{
    [TestFixture]
    class CurrencyConverterTest
    {
        [Test]
        public void DkktoEurTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.EUR);

            Assert.AreEqual(result, converter.DkkToEur(dkk));
        }

        [Test]
        public void DkktoUsdTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.USD);

            Assert.AreEqual(result, converter.DkkToUsd(dkk));
        }

        [Test]
        public void DkktoGbpTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.GBP);

            Assert.AreEqual(result, converter.DkkToGbp(dkk));
        }

        [Test]
        public void DkktoCnyTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.CNY);

            Assert.AreEqual(result, converter.DkkToCny(dkk));
        }

        [Test]
        public void DkktoCadTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.CAD);

            Assert.AreEqual(result, converter.DkkToCad(dkk));
        }

        [Test]
        public void DkktoJpyTest()
        {
            var converter = new Converter();
            int dkk = 150;
            int result = Convert.ToInt32(150 * converter.valutaData.Rates.JPY);

            Assert.AreEqual(result, converter.DkkToJpy(dkk));
        }

        [Test]
        public void StartupDataLoadTest()
        {
            var converter = new Converter();

            Assert.NotNull(converter.valutaData);
        }


    }
}
