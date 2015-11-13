using DomainModel.DomainModel;
using MovieShopUser.Models;
using MoviesShopGateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopUser.Controllers
{
    public class CustomerController : Controller
    {
        Facade facade = new Facade();

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserLogin(string UserEmail, string Password)
        {
            Customer customer = facade.GetCustomerGateway().getCustomer(UserEmail);
            if (customer != null && customer.Password.Equals(Password))
            {
                Session["Username"] = customer.FirstName + " " + customer.LastName;
                Session["UserId"] = customer.Id;
            }
            return Redirect("~/Home/Index");
        }

        [HttpGet]
        public ActionResult UserProfile()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserLogout()
        {
            Session["UserId"] = null;
            Session["UserName"] = null;
            return RedirectToAction("Index", "Home"); 
        }

        [HttpGet]
        public ActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(RegisterModel registerModel)
        {
            ModelState.Remove("Customer.Password");
            if (ModelState.IsValid)
            {
                registerModel.Customer.Password = registerModel.Password;
                facade.GetCustomerGateway().Add(registerModel.Customer);
                return RedirectToAction("Index", "Home");
            }
            return View(registerModel);
        }
    }
}