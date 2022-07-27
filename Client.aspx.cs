using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employeeList = new List<Employee>();

            employeeList = new Employee().GetEmployeesValues();

            this.GridView1.DataSource = employeeList;
            this.GridView1.DataBind();
        }
    }
    
}
