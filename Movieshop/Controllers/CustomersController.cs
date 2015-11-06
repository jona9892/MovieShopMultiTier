using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using MoviesShopProxy;

namespace Movieshop.Controllers
{
    public class CustomersController : Controller
    {
        private Facade facade = new Facade();

        // GET: Customers
        public ActionResult Index(bool? asc)
        {
            bool sortDirection = asc.HasValue ? asc.Value : false;
            ViewBag.sortDirection = !sortDirection;

            List<Customer> customers = facade.GetCustomerRepository().ReadAll(sortDirection);
            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            
            Customer customer = facade.GetCustomerRepository().Read(id);

            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
                facade.GetCustomerRepository().Add(customer);
                return RedirectToAction("Index");
            
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = facade.GetCustomerRepository().Read(id);
            customer.Adress = facade.GetAddressRepository().Read(customer.Adress.Id);
            return View(customer);
        }

        // POST: Customers/Edit/5

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {

            facade.GetCustomerRepository().Update(customer);
            facade.GetAddressRepository().Update(customer.Adress);
            return RedirectToAction("Index");
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {

            Customer customer = facade.GetCustomerRepository().Read(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Customer customer)
        {
            facade.GetCustomerRepository().Delete(customer);
            return RedirectToAction("Index");
        }

        
    }
}
