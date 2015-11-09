using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services
{
    public class CustomerGatewayService : IGatewayService<Customer>
    {
        public Customer Add(Customer t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:35459/API/Customer", t).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Delete(Customer t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Customer" + t.Id).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public Customer Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Customer" + id).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }

        public List<Customer> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Customer").Result;
                return response.Content.ReadAsAsync<List<Customer>>().Result;
            }
        }

        public List<Customer> ReadAll(bool? asc)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Customer").Result;
                return response.Content.ReadAsAsync<List<Customer>>().Result;
            }
        }

        public Customer Update(Customer t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Customer", t).Result;
                return response.Content.ReadAsAsync<Customer>().Result;
            }
        }
    }
}
