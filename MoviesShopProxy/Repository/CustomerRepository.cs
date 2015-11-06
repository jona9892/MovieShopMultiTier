using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Customers.Add(customer);
                //Execute the queries
                ctx.SaveChanges();
            }
        }


        public List<Customer> ReadAll(bool asc = true)
        {
            using (var ctx = new MovieShopContextDB())
            {
                if (asc)
                {
                    return ctx.Customers.Include("Adress").OrderBy(x => x.FirstName).ToList();
                }
                return ctx.Customers.Include("Adress").OrderByDescending(x => x.FirstName).ToList();
            }
        }

        public Customer Read(int customerID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Customers.Include("Adress").FirstOrDefault(item => item.Id == customerID);
            }
        }

        public void Update(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var customerDB = ctx.Customers.FirstOrDefault(item => item.Id == customer.Id);
                customerDB.FirstName = customer.FirstName;
                customerDB.LastName = customer.LastName;
                customerDB.Email = customer.Email;
                customerDB.Adress = ctx.Adresses.FirstOrDefault(item => item.Id == customer.Adress.Id);
                ctx.SaveChanges();
               
            }
        }

        public void Delete(Customer customer)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var customerDB = ctx.Customers.FirstOrDefault(item => item.Id == customer.Id);
                ctx.Customers.Remove(customerDB);
                ctx.SaveChanges();
            }
        }

    }
}
