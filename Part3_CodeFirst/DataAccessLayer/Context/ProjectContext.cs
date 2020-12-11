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
            //Connection string ifademizi constructor'da yazıyoruz ki ilgili sınıftan instance alındığında yani ProjectContext sınıfım initialize edildiğinde bağlantı işlemi otomatik olarak gerçekleşsin.
            //Windows Authentication
            Database.Connection.ConnectionString = @"Server=DESKTOP-LL1KD55\SQLEXPRESS;Database=YMS5177CodeFirstDb;Integrated Security=True;";
            //Sql Server Authentication
            //Database.Connection.ConnectionString = @"Server=.;Database=TMS5177CodeFirstDb;uid=sa;pwd=123";
        }
        //Artık sınıflarımıza sizler birer tablo olacaksıınız deme vakti geldi.CRUD operasyonlarında varlıkların DbSet<> edilmiş halleri üzerinden DbContext sınıfından kalıtım almış ProjectContext.cs instance vasıtasıyla yürüteceğim.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

        //BaseEntity'i neden DbSet<> etmedik=
        //BaseEntity.cs sınıfı zaten diğer sınıflara kalıtım yoluyla özellikleri aktardığından BaseEntity.cs sınıfının tablo olarak yapı kaldırmasına gerek yoktur.Zaten DbSet<> ettiğimiz sınıflarımız bu özelliklere sahip,bu yüzden bir daha BaseEntity isminde veritabanında tabloya ihtiyacımız duymadıgımdan DbSet<> edilmedi.
    }
}
