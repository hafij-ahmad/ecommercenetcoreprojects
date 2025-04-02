using EcommerceWebAppAngularjs.Data;
using EcommerceWebAppAngularjs.Model;
using EcommerceWebAppAngularjs.Services.infrustructres;
using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EcommerceWebAppAngularjs.Services.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Count()
        {
            return _dbContext.Customers.Count();
        }

        public void Delete(int id)
        {
            var customerrow = _dbContext.Customers.FirstOrDefault(c => c.Id == id.ToString());
            if (customerrow != null)
            {
                _dbContext.Customers.Remove(customerrow);
            }
        }

        public Customer GetCustomer(int id)
        {
            var customerrow = _dbContext.Customers.FirstOrDefault(c => c.Id == id.ToString());
            if (customerrow != null)
            {
                return customerrow;
            }
            return null;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _dbContext.Customers;
        }

        public void Insert(Customer customer)
        {
            _dbContext.Customers.Add(customer);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Updatde(Customer customer)
        {
            var customerrow = _dbContext.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (customerrow != null)
            {
                _dbContext.Customers.Update(customerrow);
            }
        }
    }
}