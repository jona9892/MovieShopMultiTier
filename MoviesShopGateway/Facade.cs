using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesShopGateway.Services;
using DomainModel.DomainModel;

namespace MoviesShopGateway
{
    public class Facade
    {
        public IGatewayService<Movie> GetMovieGateway()
        {
            return new MovieGatewayService();
        }

        public IGatewayService<Genre> GetGenreGateway()
        {
            return new GenreGatewayService();
        }

        public IGatewayService<Adress> GetAddressGateway()
        {
            return new AddressGatewayService();
        }

        public IGatewayService<Order> GetOrderGateway()
        {
            throw new NotImplementedException();
        }

        public IGatewayService<Customer> GetCustomerGateway()
        {
            return new CustomerGatewayService();
        }
    }
}
