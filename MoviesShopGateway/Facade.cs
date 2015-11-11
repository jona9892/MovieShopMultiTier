using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DomainModel;
using MoviesShopGateway.Services.Abstraction;
using MoviesShopGateway.Services.Implementation;

namespace MoviesShopGateway
{
    public class Facade
    {
        public AbstractGatewayService<Movie> GetMovieGateway()
        {
            return new MovieGatewayService();
        }

        public AbstractGatewayService<Genre> GetGenreGateway()
        {
            return new GenreGatewayService();
        }

        public AbstractGatewayService<Adress> GetAddressGateway()
        {
            return new AddressGatewayService();
        }

        public IOrderGatewayService<Order> GetOrderGateway()
        {
            return new OrderGatewayService();
        }

        public ICustomerGatewayService<Customer> GetCustomerGateway()
        {
            return new CustomerGatewayService();
        }
    }
}
