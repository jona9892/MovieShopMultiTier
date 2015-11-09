using DomainModel.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopGateway.Services
{
    class GenreGatewayService : IGatewayService<Genre>
    {
        public Genre Add(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:4835/api/genres/", t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Delete(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync("http://localhost:4835/api/genres/" + t.Id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:4835/api/genres/" + id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public List<Genre> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:4835/api/genres/").Result;
                return response.Content.ReadAsAsync<List<Genre>>().Result;
            }
        }

        public Genre Update(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync("http://localhost:4835/api/genres/", t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }
    }
}
