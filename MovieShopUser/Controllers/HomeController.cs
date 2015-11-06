using MovieShopUser.Models;
using MovieShopUser.Models.ViewModels;
using MoviesShopProxy;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{ 
    public class HomeController : Controller
    {

        Facade facade = new Facade();

        public ActionResult Index(int? genreId, string searchString = "")
        {
            

            var movies = facade.GetMovieRepository().ReadAll();

            if (genreId.HasValue)
            {
                movies = movies.Where(x => x.Genre.Id == genreId.Value).ToList();
            }

            if (searchString != "")
            {
                
                movies = movies.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();
            }

            return View(movies);
        }

        public ActionResult GenreDropDown()
        {
            var genres = facade.GetGenreRepository().ReadAll().ToList();

            return PartialView(genres);
        }

        [HttpGet]
        public ActionResult Verification(int movieId)
        {
            var movie = facade.GetMovieRepository().Read(movieId);
            return View(movie);
        }

        [HttpGet]
        public ActionResult CustomerEdit(string eMail, int movieId)
        {

            var customers = facade.GetCustomerRepository().ReadAll();


            CustomerViewModel viewModel = new CustomerViewModel()
            {
                Movie = facade.GetMovieRepository().Read(movieId),
                Customer = customers.Where(x => x.Email == eMail).FirstOrDefault(),
                Address = customers.Where(x => x.Email == eMail).FirstOrDefault().Adress

            };
           

            return View(viewModel);
        }
    
        [HttpPost]
        public ActionResult CustomerEdit(int movieId, Customer customer, Adress address)
        {
            Movie movie = facade.GetMovieRepository().Read(movieId);
            customer.Adress = address;
            facade.GetCustomerRepository().Update(customer);
            facade.GetAddressRepository().Update(customer.Adress);

            Order order = new Order()
            {
                Date = DateTime.Now,
                CustomerId = customer.Id,
                MovieId = movieId
            };
            facade.GetOrderRepository().Add(order);

            return RedirectToAction("OrderCompletion", new { movieId = movieId});
        }


        [HttpGet]
        public ActionResult OrderCompletion(int movieId)
        {
            Movie movie = facade.GetMovieRepository().Read(movieId);
            return View(movie);            
        }


        [HttpGet]
        public ActionResult NewCustomer(int movieId)
        {
            CustomerViewModel viewModel = new CustomerViewModel()
            {
                Movie = facade.GetMovieRepository().Read(movieId)
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult NewCustomerCreate(int movieId, Customer customer, Adress address)
        {
            
            CustomerViewModel viewModel = new CustomerViewModel()
            {
                Movie = facade.GetMovieRepository().Read(movieId)
                
            };
            customer.Adress = address;
            facade.GetCustomerRepository().Add(customer);
             

            Order order = new Order()
            {
                Date = DateTime.Now,
                CustomerId = customer.Id,
                MovieId = movieId
            };
            facade.GetOrderRepository().Add(order);
            return View(viewModel);
        }




        public ActionResult Info(int id)
        {
            return View(facade.GetMovieRepository().Read(id));
        }
    }
}