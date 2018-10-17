using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Linq_filters : System.Web.UI.Page
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        List<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
        var result = from student in studentList where student.Age > 10 && student.Age <= 20 select student.StudentName;

        var overLoadResult = studentList.Where(s => s.Age > 5 && s.Age < 19);

        var sortResult = from student in studentList where student.Age > 15 orderby student.Age descending select student.Age;

        var sortResultEM = studentList.OrderByDescending(s => s.Age);
        lblResult.Text = "<br>";
        foreach (string s in result)
        {
            lblResult.Text += s+"<br>"; 
        }
        lblResult.Text += "<br>";
        foreach (var s in overLoadResult)
        {
            lblResult.Text += s.StudentName + "<br>";
        }
        lblResult.Text += "<br>";
        foreach (int i in sortResult)
        {
            lblResult.Text += i + "<br>";
        }
        lblResult.Text += "<br>";
        foreach (var i in sortResultEM)
        {
            lblResult.Text += i.Age + "<br>";
        }
    }
}