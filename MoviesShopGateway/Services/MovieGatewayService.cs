using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DomainModel.DomainModel;

namespace MoviesShopGateway.Services
{
    public class MovieGatewayService : IGatewayService<Movie>
    {

        public Movie Add(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:35459/API/Movies", movie).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Movies" + id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Update(Movie t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Movies", t).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Delete(Movie t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Movies" + t.Id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public List<Movie> ReadAll(bool? asc)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Movies").Result;
                return response.Content.ReadAsAsync<List<Movie>>().Result;
            }
        }

        public List<Movie> ReadAll()
        {
        }
    }
}
