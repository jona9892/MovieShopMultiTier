using MovieShopUser.Models;
using MoviesShopProxy;
using MoviesShopProxy.DomainModel;
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
            if(Session["ShoppingCart"] == null)
            {
                Session["ShoppingCart"] = new ShoppingCart();
            }
            return View(facade.GetOrderRepository().ReadAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Order order)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(int orderId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Order order)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int orderId)
        {
            
            return View();
        }

        
        [HttpPost]
        public ActionResult DeleteConfirmed(Order order)
        {
           
            return RedirectToAction("Index");
        }

    }
}