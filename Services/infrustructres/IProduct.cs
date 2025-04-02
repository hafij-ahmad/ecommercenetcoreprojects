using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();

        void Save();
        void Insert(Product product);

        void Updatde(Product product);

        void Delete(int id);

        int Count();

        Product GetProduct(int Id);

    }
}
