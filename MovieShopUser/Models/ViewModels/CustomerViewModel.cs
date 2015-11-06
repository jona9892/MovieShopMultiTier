using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models.ViewModels
{
    public class CustomerViewModel
    {  
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
        public Adress Address { get; set; }

    }
}