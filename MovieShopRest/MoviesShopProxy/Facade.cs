using MovieShopDAL.Context;
using MovieShopDAL.DomainModel;
using MovieShopDAL.Repository;
using MoviesShopDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL
{
    public class Facade
    {
        private IRepository<Movie> movieRepo;
        private IRepository<Genre> genreRepo;
        private IRepository<Customer> customerRepo;
        private IRepository<Order> orderRepo;
        private IRepository<Adress> addressRepo;
        private MovieShopContextDB ctx = new MovieShopContextDB();

        
        
        public IRepository<Movie> GetMovieRepository()
        {
            if (movieRepo == null) {
                movieRepo = new MovieRepository(ctx);
            }
            return movieRepo;
        }

        public IRepository<Genre> GetGenreRepository()
        {
            if (genreRepo == null)
            {
                genreRepo = new GenreRepository(ctx);
            }
            return genreRepo;
        }

        public IRepository<Customer> GetCustomerRepository()
        {
            if (customerRepo == null)
            {
                customerRepo = new CustomerRepository(ctx);
            }
            return customerRepo;
        }

        public IRepository<Order> GetOrderRepository()
        {
            if (orderRepo == null)
            {
                orderRepo = new OrderRepository(ctx);
            }
            return orderRepo;
        }

        public IRepository<Adress> GetAddressRepository()
        {
            if (addressRepo == null)
            {
                addressRepo = new AddressRepository(ctx);
            }
            return addressRepo;
        }
    }
}
