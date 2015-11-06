using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class OrderViewModel
    {
        public List<Order> orders { get; set; }
        public List<Customer> customers { get; set; }
        public List<Movie> movies { get; set; }


    }
}