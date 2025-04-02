using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class SubCategoryRepository : ISubCategory
    {
        private readonly ApplicationDbContext dbContext;
        public SubCategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public int Count()
        {
           return  dbContext.SubCategorys.Count();
        }

        public void Delete(int id)
        {
            var subcategoryrow = dbContext.SubCategorys.FirstOrDefault(S => S.Id == id);
            if(subcategoryrow!=null)
            {
                dbContext.SubCategorys.Remove(subcategoryrow);
            }
        }

        public SubCategory GetSubCategory(int id)
        {
            var subcategoryrow = dbContext.SubCategorys.FirstOrDefault(S => S.Id==id);
            if (subcategoryrow != null)
            {
                return subcategoryrow;
            }
            return null;
        }

        public void Insert(SubCategory subCategory)
        {
            dbContext.SubCategorys.Add(subCategory);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public IEnumerable<SubCategory> subCategories()
        {
            return dbContext.SubCategorys;
        }

        public void Updatde(SubCategory subCategory)
        {
            var subcategoryrow = dbContext.SubCategorys.FirstOrDefault(S => S.Id == subCategory.Id);
            if (subcategoryrow != null)
            {
                dbContext.SubCategorys.Update(subcategoryrow);
            }
        }
    }
}
