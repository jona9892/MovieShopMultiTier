using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Context
{

    public class MovieShopContextDB : DbContext
    {
        public MovieShopContextDB(): base("MovieshopDB")
        {
            Database.SetInitializer(new MovieShopDBInitializer());
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
