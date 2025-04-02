using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
 public    interface ICardItem
    {

        IEnumerable<CartItem> GetCardItems();

        void Save();
        void Insert(CartItem cardItem);

        void Updatde(CartItem cardItem);

        void Delete(int id);

        int Count();

        CartItem GetCardItem(int  id);
    }
}
