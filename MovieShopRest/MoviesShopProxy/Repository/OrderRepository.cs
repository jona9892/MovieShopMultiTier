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
    public class OrderRepository : IRepository<Order>
    {
        MovieShopContextDB ctx;

        public OrderRepository(MovieShopContextDB context)
        {
            ctx = context;
        }

        public Order Add(Order order)
        {
                //Create the queries
                ctx.Orders.Add(order);
                //Execute the queries
                ctx.SaveChanges();
                return order;
            
        }

        public List<Order> ReadAll()
        {
            
                return ctx.Orders.Include("Customer").Include("Movie").ToList();
            
        }

        public Order Read(int orderID)
        {
            
                return ctx.Orders.Include("Movie").Include("Customer").ToList().FirstOrDefault(item => item.Id == orderID);
            
        }

        public Order Update(Order order)
        {
            
                var orderDB = ctx.Orders.ToList().FirstOrDefault(item => item.Id == order.Id);
                orderDB.Customer = order.Customer;
                orderDB.Date = order.Date;
                ctx.SaveChanges();
                return order;
                    
                
            
        }

        public Order Delete(Order order)
        {
            
                var orderDB = ctx.Orders.ToList().FirstOrDefault(item => item.Id == order.Id);
                ctx.Orders.Remove(orderDB);
                ctx.SaveChanges();
                return order;
            
        }

    }
}

