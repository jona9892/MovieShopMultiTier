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
    public class GenresController : Controller
    {

        private Facade facade = new Facade();

        // GET: Genres
        public ActionResult Index(bool? asc)
        {
            bool sortDirection = asc.HasValue ? asc.Value : false;
            ViewBag.sortDirection = !sortDirection;

            List<Genre> genres = facade.GetGenreRepository().ReadAll(sortDirection);
            return View(genres);
        }

        // GET: Genres/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")]Genre genre)
        {
            if (ModelState.IsValid)
            {
                facade.GetGenreRepository().Add(genre);
                return RedirectToAction("Index");
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Genre genreT = facade.GetGenreRepository().Read(id);
            return View(genreT);
        }

        // POST: Genres/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Name")]Genre genre)
        {
            
                facade.GetGenreRepository().Update(genre);
                return RedirectToAction("Index");
            
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int id)
        {
            Genre genre = facade.GetGenreRepository().Read(id);
            if (genre == null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Genre genre)
        {
            facade.GetGenreRepository().Delete(genre);
            return RedirectToAction("Index");
        }
    }
}
