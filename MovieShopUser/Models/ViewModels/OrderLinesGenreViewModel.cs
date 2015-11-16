using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models.ViewModels
{
    public class OrderLinesGenreViewModel
    {
        public OrderLinesGenreViewModel()
        {
            OrderLines = new List<OrderLine>();
            Genres = new List<Genre>();
        }

        public List<OrderLine> OrderLines { get; set; }
        public List<Genre> Genres { get; set; }
    }
}