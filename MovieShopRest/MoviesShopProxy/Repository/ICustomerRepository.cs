using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopDAL.Repository
{
    public interface ICustomerRepository<T> : IRepository<Customer>
    {
        T GetCustomer(string email);
    }
}
