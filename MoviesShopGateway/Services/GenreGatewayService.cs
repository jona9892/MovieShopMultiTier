﻿using DomainModel.DomainModel;
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
                HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:4835/api/genre/", t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Delete(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync("http://localhost:4835/api/genre/" + t.Id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Read(int id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:4835/api/genre/" + id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public IEnumerable<Genre> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync("http://localhost:4835/api/genre/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Genre>>().Result;
            }
        }

<<<<<<< HEAD
=======
        public List<Genre> ReadAll(bool? asc)
        {
        }

>>>>>>> 9fc9b2c17d9a54ea350b8a402c7ab7b96f0e5dc4
        public Genre Update(Genre t)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsJsonAsync("http://localhost:4835/api/genre/", t).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }
    }
}
