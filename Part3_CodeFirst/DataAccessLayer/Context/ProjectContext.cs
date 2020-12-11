using Part3_CodeFirst.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3_CodeFirst.DataAccessLayer.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
           
            Database.Connection.ConnectionString = @"Server=DESKTOP-LL1KD55\SQLEXPRESS;Database=YMS5177CodeFirstDb;Integrated Security=True;";
            
        }
        

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers{ get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
