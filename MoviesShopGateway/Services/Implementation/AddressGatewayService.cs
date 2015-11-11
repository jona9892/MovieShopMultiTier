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
    class AddressGatewayService : AbstractGatewayService<Adress>
    {
        public Adress Add(Adress t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:35459/API/Adress/", t).Result;
                return response.Content.ReadAsAsync<Adress>().Result;
            }
        }

        public Adress Delete(Adress t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Adress/" + t.Id).Result;
                return response.Content.ReadAsAsync<Adress>().Result;
            }
        }

        public Adress Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Adress/" + id).Result;
                return response.Content.ReadAsAsync<Adress>().Result;
            }
        }

        public IEnumerable<Adress> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Adress/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Adress>>().Result;
            }
        }

        public Adress Update(Adress t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Adress/" + t.Id, t).Result;
                return response.Content.ReadAsAsync<Adress>().Result;
            }
        }
    }
}
