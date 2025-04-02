using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }     

        public int Count()
        {
            return dbContext.Categorys.Count();
        }

        public void Delete(int id)
        {
            var deleteterow = dbContext.Categorys.FirstOrDefault(C => C.Id == id);
            if(deleteterow!=null)
            {
                dbContext.Categorys.Remove(deleteterow);

            }
        }

        public IEnumerable<Category> GetCategories()
        {
            return dbContext.Categorys;
        }

        public Category GetCategory(int Id)
        {
            var categoryrow = dbContext.Categorys.FirstOrDefault(C => C.Id == Id);
            if(categoryrow!=null)
            {
                return categoryrow;
            }
            return null;
        }

        public void Insert(Category category)
        {
            dbContext.Categorys.Add(category);
        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Update(Category category)
        {
            var categoryrow = dbContext.Categorys.FirstOrDefault(C => C.Id == category.Id);
           if(categoryrow!=null)
            {
                dbContext.Categorys.Update(categoryrow);

            }
        }
    }
}
