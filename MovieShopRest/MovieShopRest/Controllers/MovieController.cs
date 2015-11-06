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
    public class MovieController : ApiController
    {
        private Facade facade = new Facade();
        public IEnumerable<Movie> GetMovies()
        {
            return new Facade().GetMovieRepository().ReadAll();
        }

        // GET api/values/5
        public Movie Get(int id)
        {
            return new Facade().GetMovieRepository().Read(id);
        }

        // POST api/values
        public Movie PostMovie(Movie movie)
        {
            return new Facade().GetMovieRepository().Add(movie);
        }

        // PUT api/values/5
        public void PutMovie(int id)
        {
            var movie = new Facade().GetMovieRepository().Read(id);
            new Facade().GetMovieRepository().Update(movie);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var movie = new Facade().GetMovieRepository().Read(id);
            new Facade().GetMovieRepository().Delete(movie);
        }

    }
}
