using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class OrderLineRepository : IOrderLine
    {
        private readonly ApplicationDbContext dbContext;
        public OrderLineRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Count()
        {
           return  dbContext.OrderLines.Count();
        }

        public void Delete(int id)
        {
            var orderlinerow = dbContext.OrderLines.FirstOrDefault(C => C.Id == id);
            if(orderlinerow!=null)
            {
                 dbContext.OrderLines.Remove(orderlinerow);
            }
        }

        public OrderLine GetOrder(int id)
        {
            var orderlinerow = dbContext.OrderLines.FirstOrDefault(C => C.Id == id);
            if(orderlinerow!=null)
            {
                return orderlinerow;
            }
            return null;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
           return dbContext.OrderLines;
        }

        public void Insert(OrderLine orderLine)
        {
            dbContext.OrderLines.Add(orderLine);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Updatde(OrderLine orderLine)
        {
            var orderlinerow = dbContext.OrderLines.FirstOrDefault(C => C.Id == orderLine.Id);
            if (orderlinerow != null)
            {
                dbContext.OrderLines.Update(orderlinerow);
            }
        }
    }
}
