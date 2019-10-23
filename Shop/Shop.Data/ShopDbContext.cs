using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
   public  class ShopDbContext:DbContext
    {
        public ShopDbContext():base("ShopConnnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<LevelPermission> LevelPermissions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        protected override void OnModelCreating(DbModelBuilder Builder)
        {

        }
    }
}
