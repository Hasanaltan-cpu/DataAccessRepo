using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
namespace Part5_LazyLoading_EagerLoading1
{
    class LazyLoadingvsEagerLoading
    {

        //What is Lazy Loading?

        //Lazy Loading means the related entities are not loaded, until we iterate through them or bind them the data.By default, LINQ to SQL loads the related entities, using Lazy Loading.
        static void Main(string[] args)
        {
          

            using (SampleDataContext context = new SampleDataContext())
            {
                foreach (Department dept in context.Departments)
                {
                    MessageBox.Show(dept.Name);
                    foreach (Employee emp in dept.Employees)
                    {
                        MessageBox.Show(emp.FirstName + "" + emp.LastName);
                    }
                    //we have one query to load the Departments and three more queries to load the employees belonging to that department. Thus, it is Lazy Loading. 
                }
            }
        }

        //What is EagerLoading?

        //In LINQ to SQL there are two ways in which we can do Eager Loading.
        // * Using DataLoadOptions
        // * Using Projection
        //For first option ;

        //"System.Data.Linq namespace." this is important point for Eagerloading.
      
        using(SampleDataContext context = new SampleDataContext())
            DataLoadOptions Load = new DataLoadOptions();
            Load.LoadWith<Department>(d => d.Employees);
            foreach (Department dept in context.Departments)
	            {
                    MessageBox.Show(dept.Name);
                foreach (Employee emp in dept.Employees)
	                {
                      MessageBox.Show(emp.FirstName+""+emp.LastName);
	                }
//Basically, we are telling along with department entites. Also, load the related Employee entities.Finally we need to associate these LoadOptions with the datacontext object.
        DataLoadOptions Load = new DataLoadOptions();
        Load.LoadWith<Department>(d => d.Employees);
        context.LoadOptions = Load;   


    }
}
}
