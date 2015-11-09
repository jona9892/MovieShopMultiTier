using DomainModel.DomainModel;
using MoviesShopGateway;
using System.Collections.Generic;
using System.Web.Mvc;

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

            List<Customer> customers = facade.GetCustomerGateway().ReadAll(sortDirection);
            return View(customers);
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            
            Customer customer = facade.GetCustomerGateway().Read(id);

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
                facade.GetCustomerGateway().Add(customer);
                return RedirectToAction("Index");
            
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = facade.GetCustomerGateway().Read(id);
            customer.Adress = facade.GetAddressGateway().Read(customer.Adress.Id);
            return View(customer);
        }

        // POST: Customers/Edit/5

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {

            facade.GetCustomerGateway().Update(customer);
            facade.GetAddressGateway().Update(customer.Adress);
            return RedirectToAction("Index");
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {

            Customer customer = facade.GetCustomerGateway().Read(id);
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
            facade.GetCustomerGateway().Delete(customer);
            return RedirectToAction("Index");
        }

        
    }
}
