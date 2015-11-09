using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<Order> orders { get; set; }
        public IEnumerable<Customer> customers { get; set; }
        public IEnumerable<Movie> movies { get; set; }


    }
}