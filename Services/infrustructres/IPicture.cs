using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
    public interface IPicture
    {
        //IEnumerable<Picture> GetPictures();

        void Save();
        void Insert(Picture picture);

        void Updatde(Picture picture);

        void Delete(int id);

       // int Count();

        Picture GetPicture(int id);
    }
}
