using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
  public   interface IOrderLine
    {
        IEnumerable<OrderLine> GetOrderLines();

        void Save();
        void Insert(OrderLine orderLine);

        void Updatde(OrderLine orderLine);

        void Delete(int id);

        int Count();

        OrderLine GetOrder(int id);
    }
}
