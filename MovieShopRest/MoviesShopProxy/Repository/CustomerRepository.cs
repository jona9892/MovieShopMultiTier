using MovieShopDAL.Context;
using MovieShopDAL.DomainModel;
using MoviesShopDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {

        MovieShopContextDB ctx;

        public CustomerRepository(MovieShopContextDB context)
        {
            ctx = context;
        }
        public Customer Add(Customer customer)
        {
            
                //Create the queries
                ctx.Customers.Add(customer);
                //Execute the queries
                ctx.SaveChanges();
                return customer;
            
        }


        public List<Customer> ReadAll()
        {
            
                return ctx.Customers.Include("Adress").ToList();
            
        }

        public Customer Read(int customerID)
        {
          
                return ctx.Customers.Include("Adress").FirstOrDefault(item => item.Id == customerID);
            
        }

        public Customer Update(Customer customer)
        {
            
                var customerDB = ctx.Customers.FirstOrDefault(item => item.Id == customer.Id);
                customerDB.FirstName = customer.FirstName;
                customerDB.LastName = customer.LastName;
                customerDB.Email = customer.Email;
                customerDB.Adress = ctx.Adresses.FirstOrDefault(item => item.Id == customer.Adress.Id);
                ctx.SaveChanges();
                return customer;
               
            
        }

        public Customer Delete(Customer customer)
        {
            
                var customerDB = ctx.Customers.FirstOrDefault(item => item.Id == customer.Id);
                ctx.Customers.Remove(customerDB);
                ctx.SaveChanges();
                return customer;
            
        }

    }
}
