using CurrencyConverter;
using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models.ViewModels
{
    public class InfoViewModel
    {
        public Movie Movie { get; set; }
        public ValutaData ValutaData { get; set; }
    }
}