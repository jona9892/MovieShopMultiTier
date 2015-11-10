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
    class GenreGatewayService : AbstractGatewayService<Genre>
    {
        public Genre Add(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:35459/API/Genre/", t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Delete(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync("http://localhost:35459/API/Genre/" + t.Id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:35459/API/Genre/" + id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public IEnumerable<Genre> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:35459/API/Genre/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Genre>>().Result;
            }
        }

        public Genre Update(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync("http://localhost:35459/API/Genre/" + t.Id, t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }
    }
}
