using Part4_YellowPages_1.EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4_YellowPages_1.DataAccessLayer.Context
{

    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-LL1KD55\SQLEXPRESS;Database=YellowPage;Integrated Security=True;";

        }


        public DbSet<User> User { get; set; }

    }
}
