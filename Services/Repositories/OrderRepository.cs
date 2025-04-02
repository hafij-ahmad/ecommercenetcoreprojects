using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class OrderRepository : IOrder
    {
        private readonly ApplicationDbContext dbContext;
        public OrderRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public int Count()
        {
           return  dbContext.Orders.Count();
        }

        public void Delete(int id)
        {
            var orderrow = dbContext.Orders.FirstOrDefault(C => C.Id == id);
            if(orderrow!=null)
            {
                dbContext.Orders.Remove(orderrow);
            }
        }

        public Order GetOrder(int id)
        {
            var orderrow = dbContext.Orders.FirstOrDefault(C => C.Id == id);
            if(orderrow!=null)
            {
                return orderrow;
            }
            return null;
        }

        public IEnumerable<Order> GetOrders()
        {
             return  dbContext.Orders;
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
