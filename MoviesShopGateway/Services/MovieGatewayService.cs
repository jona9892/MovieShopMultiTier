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
                    client.PostAsJsonAsync("http://localhost:35459/API/Movie/", movie).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Read(int id)
        {
            using (var client = new HttpClient())
            {
                //Returns deserialized movie data object with given id from our Wep API local host (readasAsync uses Jsonformatter)
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Movie/" + id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Update(Movie t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:35459/API/Movie/", t).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Delete(Movie t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:35459/API/Movie/" + t.Id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public IEnumerable<Movie> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:35459/API/Movie").Result;
                return response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
            }
        }
    }
}
