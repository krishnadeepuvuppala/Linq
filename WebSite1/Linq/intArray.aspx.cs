using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Linq_intArray : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GetResult_Click(object sender, EventArgs e)
    {
        int[] marks = { 33, 99, 44, 45, 87, 65, 77 };
        IEnumerable<int> passMarks = from m in marks where m > 50 select m;
        IEnumerable<int> failed = marks.Where(m => m < 50);
        string sResult = "<br>";
        foreach (int mark in passMarks)
        {
            sResult += mark + ", "; 
        }
        sResult += "<br>";
        foreach (int mark in failed)
        {
            sResult += mark + ", ";
        }
        lblResult.Text = sResult;

    }
}