using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Linq_joins : System.Web.UI.Page
{
    class DepartmentClass
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }

    class EmployeeClass
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        List<DepartmentClass> departments = new List<DepartmentClass>();
        departments.Add(new DepartmentClass { DepartmentId = 1, Name = "Account" });
        departments.Add(new DepartmentClass { DepartmentId = 2, Name = "Sales" });
        departments.Add(new DepartmentClass { DepartmentId = 3, Name = "Marketing" });

        List<EmployeeClass> employees = new List<EmployeeClass>();
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "William" });
        employees.Add(new EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Miley" });
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Benjamin" });

        //var result = from emp in employees where emp.EmployeeId == 3 select emp;
        var EmployeeDepartment = from emp in employees join dp in departments on emp.DepartmentId equals dp.DepartmentId select new {
            Employee = emp.EmployeeName,
            Department = dp.Name
        };
        string sResult = "<br>";
        //foreach (var emp in result)
        //{
        //    sResult += emp.EmployeeName + ", "; 
        //}
        foreach (var emp in EmployeeDepartment)
        {
            sResult += emp.Employee + ", "+ emp.Department+"<br>";
        }
        lblResult.Text = sResult;
    }
}