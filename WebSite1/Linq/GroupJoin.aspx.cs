using System;
using System.Collections.Generic;
using System.Linq;

public partial class Linq_GroupJoin : System.Web.UI.Page
{
    public class DepartmentClass
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeClass
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
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "Won" });
        employees.Add(new EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Merlin" });
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Ben" });
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 1, EmployeeName = "Winston" });
        employees.Add(new EmployeeClass { DepartmentId = 2, EmployeeId = 2, EmployeeName = "Moby" });
        employees.Add(new EmployeeClass { DepartmentId = 1, EmployeeId = 3, EmployeeName = "Brandon" });
        lblResult.Text = "<br>";
        //normal join
        //var ordinaryJoin = from employee in employees
        //                   join department in departments on employee.DepartmentId equals department.DepartmentId
        //                   //where employee.DepartmentId == 3
        //                   select new
        //                   {
        //                       employee.EmployeeName,
        //                       Department_Name = department.Name
        //                   };
        //foreach (var v in ordinaryJoin)
        //{
        //    lblResult.Text += "<br>" + v.EmployeeName + ", " + v.Department_Name;
        //}

        ////try 
        //var ordinaryJoin2 = departments.GroupJoin(departments d ) 

        //foreach (var v in ordinaryJoin2)
        //{
        //    //lblResult.Text += "<br>" + v.departments. + ", " + v.Department_Name;
        //}
    }
}