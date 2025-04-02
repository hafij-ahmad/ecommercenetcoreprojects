using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
   public interface ICategory
    {
        IEnumerable<Category> GetCategories();//List Type data display

        void Save();//svae data

        void Update(Category category);//Update data

        void Insert(Category category);//Inser data

        void Delete(int id);

        Category GetCategory(int  Id);

        int Count();

      

    }
}
