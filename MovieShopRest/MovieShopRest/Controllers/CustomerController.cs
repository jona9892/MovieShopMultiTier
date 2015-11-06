using MovieShopDAL;
using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieShopRest.Controllers
{
    public class CustomerController : ApiController
    {
        private Facade facade = new Facade();
        public IEnumerable<Customer> GetCustomers()
        {
            return new Facade().GetCustomerRepository().ReadAll();
        }

        // GET api/values/5
        public Customer Get(int id)
        {
            return new Facade().GetCustomerRepository().Read(id);
        }

        // POST api/values
        public Customer PostCustomer(Customer customer)
        {
            return new Facade().GetCustomerRepository().Add(customer);
        }

        // PUT api/values/5
        public void PutCustomer(int id)
        {
            var customer = new Facade().GetCustomerRepository().Read(id);
            new Facade().GetCustomerRepository().Update(customer);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var customer = new Facade().GetCustomerRepository().Read(id);
            new Facade().GetCustomerRepository().Delete(customer);
        }
    }
}
