using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class CartItemRepository : ICardItem
    {
        private readonly ApplicationDbContext dbContext;
        public CartItemRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public int Count()
        {
           return  dbContext.CartItems.Count();
        }

        public void Delete(int id)
        {
            var carditemrow = dbContext.CartItems.FirstOrDefault(C => C.Id == id);
            if(carditemrow!=null)
            {
                dbContext.CartItems.Remove(carditemrow);
            }
           
        }

        public CartItem GetCardItem(int id)
        {
            var carditemrow = dbContext.CartItems.FirstOrDefault(C => C.Id == id);
            if (carditemrow != null)
            {
                return carditemrow;
            }
            return null;
        }

        public IEnumerable<CartItem> GetCardItems()
        {
           return  dbContext.CartItems;
        }

        public void Insert(CartItem cardItem)
        {
            dbContext.CartItems.Add(cardItem);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Updatde(CartItem cardItem)
        {
            var cardrow = dbContext.CartItems.FirstOrDefault(C => C.Id == cardItem.Id);
            if(cardItem!=null)
            {
                dbContext.CartItems.Update(cardrow);
            }
        }
    }
}
