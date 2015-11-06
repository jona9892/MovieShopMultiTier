using Movieshop.Models.ViewModels;
using MoviesShopProxy;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movieshop.Controllers
{
    public class MoviesController : Controller
    {
        private Facade facade = new Facade();
        // GET: Movies
        [HttpGet]
        public ActionResult Index(bool? asc)
        {
            bool sortDirection = asc.HasValue ? asc.Value : false;
            ViewBag.sortDirection = !sortDirection;

            List<Movie> movies = facade.GetMovieRepository().ReadAll(sortDirection);
            return View(movies);
        }

        [HttpGet]
        public ActionResult Create()
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Genres = facade.GetGenreRepository().ReadAll().ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Genre = facade.GetGenreRepository().Read(movie.Genre.Id);

                facade.GetMovieRepository().Add(movie);
                return Redirect("Index");
            }
            return View(movie);
        }

        [HttpGet]
        public ActionResult Update(int Id)
        {
            MovieViewModel viewModel = new MovieViewModel()
            {
                Movie = facade.GetMovieRepository().Read(Id),
                Genres = facade.GetGenreRepository().ReadAll()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(Movie Movie)
        {
            Movie.Genre = facade.GetGenreRepository().Read(Movie.Genre.Id);
            facade.GetMovieRepository().Update(Movie);
            return Redirect("~/Movies/Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Movie movie = facade.GetMovieRepository().Read(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Delete(Movie movie)
        {
            facade.GetMovieRepository().Delete(movie);
            return Redirect("~/Movies/Index");
        }
    }
}