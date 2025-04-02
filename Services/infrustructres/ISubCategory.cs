using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
    public interface ISubCategory
    {

        IEnumerable<SubCategory> subCategories();

        void Save();
        void Insert(SubCategory subCategory);

        void Updatde(SubCategory  subCategory);

        void Delete(int id);

        int Count();

        SubCategory GetSubCategory(int id);
    }
}
