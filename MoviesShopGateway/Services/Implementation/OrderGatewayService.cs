using DomainModel.DomainModel;
using MoviesShopGateway.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services.Implementation
{
    public class OrderGatewayService : IOrderGatewayService<Order>
    {
        public Order Add(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:35459/API/Order/", t).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Delete(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Order/" + t.Id).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Order/" + id).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public IEnumerable<Order> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Order/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Order>>().Result;
            }
        }

        public Order Update(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Order/" + t.Id, t).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }
    }
}
