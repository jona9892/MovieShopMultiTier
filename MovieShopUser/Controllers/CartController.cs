using DomainModel.DomainModel;
using MovieShopUser.Models;
using MovieShopUser.Models.ViewModels;
using MoviesShopGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{
    public class CartController : Controller
    {
        Facade facade = new Facade();
        // GET: Cart
        public ActionResult Index()
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            List<OrderLine> lines;

            if (cart == null)
            {
                lines = new List<OrderLine>();
            }
            else
            {
                lines = cart.OrderLines;
            }

            CartViewModel viewModel = new CartViewModel()
            {
                Orderlines = lines
            };
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult DeleteConfirmed(Order order)
        {
           
            return RedirectToAction("Index");
        }

        public ActionResult AddToCart(int movieId)
        {
            ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
            if (cart == null)
            {
                cart = new ShoppingCart();
            }

            Movie movie = facade.GetMovieGateway().Read(movieId);
            OrderLine line = new OrderLine() { Movie = movie, Amount = 1};
            cart.AddOrderLine(line);

            Session["ShoppingCart"] = cart;
            return Redirect("Index");
        }

        public ActionResult CompleteOrder()
        {
            try
            {
                int userId = (int)Session["UserId"];
                int customer = facade.GetCustomerGateway().Read(userId).Id;
                ShoppingCart cart = Session["ShoppingCart"] as ShoppingCart;
                
                Order order = new Order()
                {
                    CustomerId = customer,
                    Date = DateTime.Now,
                    OrderLines = cart.OrderLines
                };
                facade.GetOrderGateway().Add(order);
                
                return View(cart.OrderLines);
            }
            catch
            {
                return View("OrderFail");
            }
        }
    }
}