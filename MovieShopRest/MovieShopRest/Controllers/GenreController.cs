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
    public class GenreController : ApiController
    {

        private Facade facade = new Facade();
        public IEnumerable<Genre> GetGenres()
        {
            return new Facade().GetGenreRepository().ReadAll();
        }

        // GET api/values/5
        public Genre Get(int id)
        {
            return new Facade().GetGenreRepository().Read(id);
        }

        // POST api/values
        public Genre PostGenre(Genre genre)
        {
            return new Facade().GetGenreRepository().Add(genre);
        }

        // PUT api/values/5
        [HttpPut]
        public void PutGenre(int id)
        {
            var genre = new Facade().GetGenreRepository().Read(id);
            new Facade().GetGenreRepository().Update(genre);
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
            var genre = new Facade().GetGenreRepository().Read(id);
            new Facade().GetGenreRepository().Delete(genre);
        }
    }
}
