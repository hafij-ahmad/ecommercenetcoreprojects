using EcommerceWebAppAngularjs.Model;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Services.infrustructres
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetCustomers();

        void Save();
        void Insert(Customer customer);

        void Updatde(Customer customer);

        void Delete(int id);

        int Count();

        Customer GetCustomer(int id);
    }
}
