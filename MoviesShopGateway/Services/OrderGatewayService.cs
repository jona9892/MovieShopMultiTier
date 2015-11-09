using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DomainModel;
using System.Net.Http;

namespace MoviesShopGateway.Services
{
    public class OrderGatewayService : IGatewayService<Order>
    {
        public Order Add(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:35459/API/Orders", t).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Delete(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Orders" + t.Id).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public Order Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Orders" + id).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }

        public List<Order> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Orders").Result;
                return response.Content.ReadAsAsync<List<Order>>().Result;
            }
        }

        public List<Order> ReadAll(bool? asc)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Orders", t).Result;
                return response.Content.ReadAsAsync<Order>().Result;
            }
        }
    }
}
