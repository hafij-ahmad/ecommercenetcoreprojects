using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
   public  interface IOrder
    {
        IEnumerable<Order> GetOrders();

        void Save();
        //void Insert(Order order);

        //void Updatde(Order order);

        void Delete(int id);

        int Count();

        Order GetOrder(int  id);
    }
}
