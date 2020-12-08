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

namespace Part_1_DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            //LinkTo() " We use this method for listing all values without any condition.It execute on the Heap Field of RAM.It creates a generic list."

            dataGridView1.DataSource = db.Employees.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Where() "It is worked for getting filter datas from table on the database with condition whic is created by us"

            dataGridView1.DataSource = db.Products.Where(x => x.CategoryID != 3).ToList(); /// ın this row we ask to sql to go to product table of nortwind.db then find categoryid is not 3 finally list to me on the datagridview.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OrderBy() "It uses for getting list which is wanted by us in terms of numeric sorting.OrderBy=>Ascending
            //OrderByDescending()"It uses for getting list which is wanted by us in terms of numeric sorting by descending.OrderByDescending=>Descending


            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitsOnOrder).ToList();//In this row we ask from sql that is a sorting list descendingly in  terms of  UnitsOnOrder.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //GroupBy() "It is used for make a group with condition which is written by us and finally group them automatically.

            dataGridView1.DataSource = db.Orders.GroupBy(x => x.EmployeeID).Select(x => new
            {
                Satıspersoneli = x.Key,
                toplamsatis = x.Sum(e => e.OrderID)
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //First() " It is used like a "TOP" logic on the SQL . This method takes us to first index whic was searched by us.
            Product product= db.Products.First();
            MessageBox.Show($"First product which is listed on the product class is: {product.ProductName}");

            Product product1 = db.Products.First(x => x.ProductID > 10);
            MessageBox.Show($" Product which ProductID is bigger than 10:{product1.ProductID} ");

            //Attention!!:If the result will Null this row does not work.That's why we should use try-catch function for preventing application break.
            try
            {
                Category category = db.Categories.First(x => x.CategoryID > 10);
                MessageBox.Show($"Category which is categoryID bigger than 10:{category.CategoryName}");

            }
            catch (Exception)
            {

               MessageBox.Show("Opps..There is no category which categoryID is not bigger than 10 ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //FirstOrDefault() "This is used for first row same logic like  "First Function Usage".Different of FirstOrDefault is to prevent application breaking and if the result will come "Null" value on the row it is written "null" directly.

            Employee employee = db.Employees.FirstOrDefault(x => x.EmployeeID>12);
            if (employee==null)
            {
                MessageBox.Show("Employee is not found..");
            }
            else
            {
                MessageBox.Show($"Employee is :{employee.EmployeeID}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Find() "As you got from the name of function,this is used to find query from database.In this method using Idendity key is logical because of Id is unique on the sql server database.

            dataGridView1.DataSource = db.Products.Where(x => x.Discontinued == false).OrderBy(x => x.ProductName).ToList();
            //We listed product which is discontinued order by productname ascendengly.

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Take () "Take works as a "TOP" function and gives an oppurtunity to print  any row which we wants on the screen.

            dataGridView1.DataSource = db.Categories.Select(x => new
            {
               CategoryID= x.CategoryID,
                CategoryName=x.CategoryName,
               PictureOfCategories= x.Picture,
                DescriptionOfCategories=x.Description
            }).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Skip() "In this method, we get skip row that we optioned.

            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.Address,
                x.FirstName,
                x.LastName,
                x.Region,
            }).Skip(5).ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Contains() "It works as a meaning of contains,we get a result from sql and then ".Contains()" we can create a condition.
            //Attention!!:This method should work with where method.

            dataGridView1.DataSource = db.Customers.Where(x => x.Region.Contains("United States")).OrderBy(x => x.CompanyName).ToList();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Any() "This method usa 2 different way:
            //*Firstly we control  that any record is included  on a List or not?
            //*Secondly we control  any record that is suitable for our conditions included on a List or not?
            //As you see,result always Yes or No that means we should use "Boolean Type" for result.

            bool result = db.Customers.Any(x => x.CompanyName == "Technology");
            MessageBox.Show(result.ToString());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Count() "It counts row numbers.The result will be "Integer Type".

            int result = db.Orders.Count();
            MessageBox.Show($"Total orders: {result}");
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Sum() "It used sum all values that we get result.

            int? totalorder = db.Orders.Sum(x => x.Order_Details.Count());
            MessageBox.Show($"Total Order:{totalorder}");

        }

        private void button13_Click(object sender, EventArgs e)
        {

            //DateDiff() " As we know from Sql DateDiff works calculate (What You Want(Year,Month,Day),Start Date,End Date).It means we want to year type End date - Start date.
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                FirstName = x.FirstName,
                Lastname = x.LastName,
                BirthDate = x.BirthDate,
                Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)//We use Sql Function that's why we should add SqlFunction to namespace with "Ctrl+."
            }).ToList();
        }
    }
}

    
        




   


