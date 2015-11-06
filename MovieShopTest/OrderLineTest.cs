using MovieShopUser;
using MovieShopUser.Models;
using MoviesShopProxy.DomainModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopTest
{
    [TestFixture]
    public class OrderLineTest
    {
        [Test]
        public void Orderline_Properties_Set_Test()
        {
            OrderLine line = new OrderLine();
            var movie = new Movie() { Id = 1, Title = "Smurf" };
            line.Movie = movie;
            line.Amount = 10;

            Assert.AreEqual(line.Movie, movie, "My movie should be the same");
            Assert.AreEqual(line.Amount, 10, "Amount should be 10");
        }


    }
}
