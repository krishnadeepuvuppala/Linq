using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Linq_Grouping : System.Web.UI.Page
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
        new Student() { StudentID = 1, StudentName = "Jack", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 2, StudentName = "Neemo",  Age = 21 } ,
        new Student() { StudentID = 2, StudentName = "Mat",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
        new Student() { StudentID = 3, StudentName = "Brandon",  Age = 18 } ,
        new Student() { StudentID = 3, StudentName = "Bron",  Age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 4, StudentName = "Rakesh" , Age = 20} ,
        new Student() { StudentID = 4, StudentName = "Rajesh" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 },
        new Student() { StudentID = 5, StudentName = "Ray" , Age = 15 },
        new Student() { StudentID = 5, StudentName = "Rick" , Age = 15 }
        };
        var groupByAge = from student in studentList group student by student.Age;
        lblResult.Text = "<br>";
        foreach (var v in groupByAge)
        {
            lblResult.Text += v.Key;
            lblResult.Text += "<br>";
            foreach (Student s in v)
                lblResult.Text += s.StudentName+"<br>";
            lblResult.Text += "<br><br>";

        }
    }
}