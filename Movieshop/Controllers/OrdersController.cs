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
using Movieshop.Models.ViewModels;

namespace Movieshop.Controllers
{
    public class OrdersController : Controller
    {
        Facade facade = new Facade();

        // GET: Orders
        public ActionResult Index(OrderViewModel model)
        {
            model.orders = facade.GetOrderRepository().ReadAll();
            model.customers = facade.GetCustomerRepository().ReadAll();
            model.movies = facade.GetMovieRepository().ReadAll();
            return View(model);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            Order order = facade.GetOrderRepository().Read(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Order order)
        {
                facade.GetOrderRepository().Add(order);
                return RedirectToAction("Index");
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            Order order = facade.GetOrderRepository().Read(id);

            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Order order)
        {
                facade.GetOrderRepository().Update(order);
                return RedirectToAction("Index");
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = facade.GetOrderRepository().Read(id);
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = facade.GetOrderRepository().Read(id);
            facade.GetOrderRepository().Delete(order);
            return RedirectToAction("Index");
        }
    }
}
