using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GetResult_Click(object sender, EventArgs e)
    {
        string[] WordTable = {"new", "Eat", "length", "jump", "laughing", "swimming", "barking" };
        var shortWords = from w in WordTable where w.Length < 5 select w;
        string sResult = "<br>";
        var longWords = WordTable.Where(w => w.Length > 5);
        var veryLongWords = from w in WordTable where w.Length > 7 select w;
        foreach(var v in shortWords)
        {
            sResult += v+", ";
        }
        sResult += "<br>";
        foreach (var v in longWords)
        {
            sResult += v + ", ";
        }
        sResult += "<br>";
        foreach (var v in veryLongWords)
        {
            sResult += v + ", ";
        }
        lblOutput.Text = sResult;
    }
}