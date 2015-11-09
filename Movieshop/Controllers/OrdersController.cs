﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Movieshop.Models.ViewModels;
using MoviesShopGateway;
using DomainModel.DomainModel;

namespace Movieshop.Controllers
{
    public class OrdersController : Controller
    {
        Facade facade = new Facade();

        // GET: Orders
        public ActionResult Index(OrderViewModel model)
        {
            model.orders = facade.GetOrderGateway().ReadAll();
            model.customers = facade.GetCustomerGateway().ReadAll();
            model.movies = facade.GetMovieGateway().ReadAll();
            return View(model);
        }

        // GET: Orders/Details/5
        public ActionResult Details(int id)
        {
            Order order = facade.GetOrderGateway().Read(id);
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
                facade.GetOrderGateway().Add(order);
                return RedirectToAction("Index");
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int id)
        {
            Order order = facade.GetOrderGateway().Read(id);

            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Order order)
        {
                facade.GetOrderGateway().Update(order);
                return RedirectToAction("Index");
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int id)
        {
            Order order = facade.GetOrderGateway().Read(id);
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = facade.GetOrderGateway().Read(id);
            facade.GetOrderGateway().Delete(order);
            return RedirectToAction("Index");
        }
    }
}
