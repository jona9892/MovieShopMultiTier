using CurrencyConverter;
using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            Converter converter = new Converter();
            valutaData = converter.valutaData;
            Orderlines = new List<OrderLine>();
        }

        public List<OrderLine> Orderlines { get; set; }
        public ValutaData valutaData { get; set; }
    }
}