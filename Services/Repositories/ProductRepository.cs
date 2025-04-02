using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext dbContext;
        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public int Count()
        {
           return dbContext.Products.Count();
        }

        public void Delete(int id)
        {
            var productrow = dbContext.Products.FirstOrDefault(P => P.Id == id);
            if(productrow!=null)
            {
                dbContext.Products.Remove(productrow);
            }
        }

        public Product GetProduct(int id)
        {
            var productrow = dbContext.Products.FirstOrDefault(P => P.Id == id);
            if(productrow!=null)
            {
                return productrow;
            }
            return null;
        }

        public IEnumerable<Product> GetProducts()
        {
             return dbContext.Products;
        }

        public void Insert(Product product)
        {
            dbContext.Products.Add(product);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Updatde(Product product)
        {
            var productrow = dbContext.Products.FirstOrDefault(P => P.Id == product.Id);
            if(productrow!=null)
            {
                dbContext.Products.Update(productrow);
            }
        }
    }
}
