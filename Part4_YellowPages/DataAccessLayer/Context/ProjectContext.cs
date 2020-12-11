using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4_YellowPages.DataAccessLayer.Context
{
    public class ProjectContext :DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP - LL1KD55\SQLEXPRESS;Database=YellowPage;Integrated Security=True;";

        }

        
            

    }
}
