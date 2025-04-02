using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class PictureRepository : IPicture
    {
        private readonly ApplicationDbContext dbContext;
        public PictureRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Delete(int id)
        {
            var picturerow = dbContext.Pictures.FirstOrDefault(P => P.Id == id);
            if(picturerow !=null)
            {
                dbContext.Pictures.Remove(picturerow);
            }
        }

        public Picture GetPicture(int id)
        {
            var picturerow = dbContext.Pictures.FirstOrDefault(P => P.Id == id);
            if(picturerow!=null)
            {
                return picturerow;
            }
            return null;
        }

        public void Insert(Picture picture)
        {
            dbContext.Pictures.Add(picture);

        }

        public void Save()
        {
            dbContext.SaveChanges();
        }

        public void Updatde(Picture picture)
        {
            var picturerow = dbContext.Pictures.FirstOrDefault(P => P.Id == picture.Id);
            if(picturerow!=null)
            {
                dbContext.Pictures.Update(picturerow);
            }
        }
    }
}
