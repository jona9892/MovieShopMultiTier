using DomainModel.DomainModel;
using Movieshop.Models.ViewModels;
using MoviesShopGateway;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Movieshop.Controllers
{
    public class MoviesController : Controller
    {
        private Facade facade = new Facade();
        
        // GET: Movies
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<Movie> movies = facade.GetMovieGateway().ReadAll();
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Genres = facade.GetGenreGateway().ReadAll().ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Genre = facade.GetGenreGateway().Read(movie.Genre.Id);

                facade.GetMovieGateway().Add(movie);
                return Redirect("Index");
            }
            return View(movie);
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Movie = facade.GetMovieGateway().Read(Id),
                Genres = facade.GetGenreGateway().ReadAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(Movie Movie)
        {
            Movie.Genre = facade.GetGenreGateway().Read(Movie.Genre.Id);
            facade.GetMovieGateway().Update(Movie);
            return Redirect("~/Movies/Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie movie = facade.GetMovieGateway().Read(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
            facade.GetMovieGateway().Delete(movie);
            return Redirect("~/Movies/Index");
        }
    }
}