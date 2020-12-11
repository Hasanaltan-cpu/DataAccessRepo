using Part2_Dbfirst_2.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part2_Dbfirst_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            //In that query we try to find employess FirstName,LastName,BirthDate and Title on the list with Linq to Entity.

            #region  Linq to Entity
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                Adı = x.FirstName,
                Soyadi = x.LastName,
                DogumTarihi = x.BirthDate,
                Unvan = x.Title,
            }).ToList();
            #endregion
            #region Linq to SQL 
            // In that query we use same query with Linq to Sql.
            var result = from emp in db.Employees
                         select new
                         {
                             emp.FirstName,
                             emp.LastName,
                             emp.BirthDate,
                             emp.Title

                         };
            dataGridView1.DataSource = result.ToList();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //I aim to get list of employees which employeeid is between 2-8 by ascending in terms of FirstName from A to Z.
            #region Linq to entity
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.EmployeeID,
                x.FirstName,
                x.LastName,
                x.TitleOfCourtesy,

            }).Where(x => x.EmployeeID > 2 && x.EmployeeID < 8).OrderBy(x => x.FirstName).ToList();
            #endregion

            #region Linq to SQL
            var result = from emp in db.Employees
                         where emp.EmployeeID > 2 && emp.EmployeeID < 8
                         orderby emp.FirstName
                         select new
                         {
                             emp.EmployeeID,
                             emp.FirstName,
                             emp.LastName,
                             emp.BirthDate,
                             emp.TitleOfCourtesy,
                         };
            dataGridView1.DataSource = result.ToList();
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //we want to list Employees which are older than 60 years old .
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.BirthDate,
                age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now),

            }).Where(x => x.age > 60).OrderBy(x => x.FirstName).ToList();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Employees which was born between 1930-1960 and list.

            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                BirthDate = SqlFunctions.DatePart("Year", x.BirthDate),
                x.Country
            }).Where(x => x.BirthDate > 1930 && x.BirthDate < 1960 && x.Country == "USA").ToList();
        } // "x.Country=="USA" ın this condition can write as "Contains" method it is same logic.

        private void button5_Click(object sender, EventArgs e)
        {
            //These query shows us our Stocks remain and i used groupby linq method here to catch from categoryID.

            dataGridView1.DataSource = db.Categories
                .Join(db.Products,
                c => c.CategoryID,
                p => p.CategoryID,
                (c, p) => new
                { c, p }).GroupBy(x => x.c.CategoryName)
                .Select(x => new
                {
                    Name = x.Key,
                    Cont = x.Sum(z => z.p.UnitsInStock)

                }).ToList();

        }

        private void button6_Click(object sender, EventArgs e)
        {

            //In this row ı demonstrate total price that we sold our products and it will be shown on the datagridview.
            dataGridView1.DataSource = db.Order_Details.Select(x => new
            {
                Overall = x.UnitPrice * x.Quantity,
                WithDiscounted = x.Quantity * x.UnitPrice * Convert.ToInt32(x.Discount),
            }).Sum(x => x.Overall - x.WithDiscounted);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                //Employees which was born today we can list with that Linq to methods.I use Sqlfunctions and date part month and day and finally list them on the datagridview.


                FirstName = x.FirstName,
                LastName = x.LastName,
                BirthMonth = SqlFunctions.DatePart("Month", x.BirthDate),
                BirthDay = SqlFunctions.DatePart("Day", x.BirthDate),
                Today = DateTime.Now,
                Photo = x.Photo,


            }).Where(x => x.BirthMonth == SqlFunctions.DatePart("Month", x.Today) && x.BirthDay == SqlFunctions.DatePart("Day", x.Today)).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            //I used Customers table and took companyName and Country Name moreover i show them on the List.
            dataGridView1.DataSource = db.Customers.Select(x =>
              new
              {
                  CompanyName = x.CompanyName,
                  Countries = x.Country,

              }).OrderBy(x => x.Countries).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //In this row main purpose is to get list customers city which is different "Berlin" and "Mexico D.F."

            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                CompanyName = x.CompanyName,
                City = x.City,

            }).Where(x => x.City != "Berlin" || x.City != "Mexico D.F.").ToList();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Customers.Select(x => new
            {
                //Result will be customers which its country is Brazil and descending by CompanyName.

                CompanyName = x.CompanyName,
                CustomerId = x.CustomerID,
                City = x.City,
                Country = x.Country,
                ContactTitle = x.ContactTitle
            }).Where(x => x.Country == "Brasil").OrderByDescending(x => x.CompanyName).ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //how much profit from products?

            dataGridView1.DataSource = db.Order_Details.Select(x => new
            {
                Product = x.Product,
                ProductId = x.ProductID,
                Order = x.Order,
                Quantity = x.Quantity,
                UnitPrice = x.UnitPrice,
            }).Sum(x => Convert.ToInt32(x.Order) * x.UnitPrice).ToString().ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //How much money do we spend to suppliers? 


            dataGridView1.DataSource = db.Orders.Join(db.Shippers,
                o => o.ShipVia,
                s => s.ShipperID,
                 (o, s) => new
                 {
                     o,
                     s
                 }).
                GroupBy(x => x.s.CompanyName).Select(x => new
                {

                    ShipperName = x.Key,
                    TotalPrice = x.Sum(z => z.o.Freight),

                }).ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //let's get the employee which like "Toast";

            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                Fullname = x.FirstName + " " + x.LastName,
                Notes = x.Notes,

            }).Where(x => x.Notes == "Toast").OrderBy(x => x.Fullname).ToList();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ///Which country we sold products?
            dataGridView1.DataSource = db.Customers.Join(db.Orders,
                c => c.CustomerID,
                o => o.CustomerID,
                (c, o) => new { c, o }
                ).GroupBy(x => x.c.Country).Select(x => new
                {
                    Country = x.Key,
                     Name = x.Select(z => z.o.ShipCountry)
                }).ToList();
        }
    }
}
