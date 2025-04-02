using EcommerceWebAppAngularjs.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.Data
{
    //public class ApplicationDbContext:DbContext
    //{
   public class ApplicationDbContext:IdentityDbContext<Customer>
    {

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategorys { get; set; }
    }
}
