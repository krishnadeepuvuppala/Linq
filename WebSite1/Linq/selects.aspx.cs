using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Linq_selects : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        string[] sSomeStrings = {"an","apple","a","day" };
        List<string> lstSomeStrings = new List<string>() {"an apple a day","empty vessels make noice" };
        var result = from sss in sSomeStrings where sss.Length >= 3 select sss.Substring(0, 3);
        var setResult = from lss in lstSomeStrings
                        from word in lss.Split(' ')
                        select word;
        lblResult.Text = string.Empty;
        lblResult.Text = "<br>";
        foreach (string s in result)
        {
            lblResult.Text += s + "<br>";
        }
        foreach (string s in setResult)
        {
            lblResult.Text += s + "<br>";
        }
    }
}