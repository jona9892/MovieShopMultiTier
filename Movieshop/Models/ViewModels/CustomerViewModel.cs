using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movieshop.Models.ViewModels
{
    public class CustomerViewModel
    {  
        public CustomerViewModel()
        {
            Addresses = new List<Adress>();
        }
        public Customer customer { get; set; }
        public IEnumerable<Adress> Addresses { get; set; }
    }
}