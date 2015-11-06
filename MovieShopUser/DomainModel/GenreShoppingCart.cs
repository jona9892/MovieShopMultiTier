using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.DomainModel
{
    public class GenreShoppingCart
    {
        public List<Genre> genres { get; set; }
        public List<int?> shoppingCart { get; set; }
    }
}