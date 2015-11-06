using MoviesShopProxy.Context;
using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Repository
{
    public class OrderRepository
    {
        public void Add(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                //Create the queries
                ctx.Orders.Add(order);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public List<Order> ReadAll()
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Orders.Include("Customer").Include("Movie").ToList();
            }
        }

        public Order Read(int orderID)
        {
            using (var ctx = new MovieShopContextDB())
            {
                return ctx.Orders.Include("Movie").Include("Customer").ToList().FirstOrDefault(item => item.Id == orderID);
            }
        }

        public void Update(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {
                var orderDB = ctx.Orders.ToList().FirstOrDefault(item => item.Id == order.Id);
                orderDB.Customer = order.Customer;
                orderDB.Date = order.Date;
                ctx.SaveChanges();
                    
                
            }
        }

        public void Delete(Order order)
        {
            using (var ctx = new MovieShopContextDB())
            {

                var orderDB = ctx.Orders.ToList().FirstOrDefault(item => item.Id == order.Id);
                ctx.Orders.Remove(orderDB);
                ctx.SaveChanges();
            }
        }

    }
}

