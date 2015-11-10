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
    public class OrderController : ApiController
    {
        Facade facade = new Facade();

        public IEnumerable<Order> GetMovies()
        {
            return new Facade().GetOrderRepository().ReadAll();
        }

        // GET api/values/5
        public Order Get(int id)
        {
            return new Facade().GetOrderRepository().Read(id);
        }

        // POST api/values
        public Order PostOrder(Order order)
        {
            return new Facade().GetOrderRepository().Add(order);
        }

        // PUT api/values/5
        public Order PutOrder(int id, Order order)
        {
            order.Id = id;
            new Facade().GetOrderRepository().Update(order);
            return order;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var order = new Facade().GetOrderRepository().Read(id);
            new Facade().GetOrderRepository().Delete(order);
        }
    }
}
