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
    public class AddressController : ApiController
    {
        private Facade facade = new Facade();
        public IEnumerable<Adress> GetCustomers()
        {
            return new Facade().GetAddressRepository().ReadAll();
        }

        // GET api/values/5
        public Adress Get(int id)
        {
            return new Facade().GetAddressRepository().Read(id);
        }

        // POST api/values
        public Adress PostAdress(Adress adress)
        {
            return new Facade().GetAddressRepository().Add(adress);
        }

        // PUT api/values/5
        public void PutAdress(int id, Adress adress)
        {
            if (adress == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                adress.Id = id;
                
                new Facade().GetAddressRepository().Update(adress);
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var customer = new Facade().GetCustomerRepository().Read(id);
            new Facade().GetCustomerRepository().Delete(customer);
        }
    }
}
