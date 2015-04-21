using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

public partial class About : Page
{

    private DatabaseHandler database;

    protected void Page_Load(object sender, EventArgs e)
    {
        database = new DatabaseHandler();

        ShowResultsFromCourseTable();
    }

    public void ShowResultsFromCourseTable()
    {
        DataTable dt = database.RetrieveTablefromCourseTable();
        
        foreach (DataRow row in dt.Rows)
        {
            string classNames = row.Field<string>(1);
            

            ClassList.DataSource = classNames;
            ClassList.DataBind();
        }
    }

    protected void RBSignUp_CheckedChanged(object sender, EventArgs e)
    {
    //    DataTable dt = database.RetrieveTablefromCourseTable();

    //    if (ClassList.)
    //    {

    //    }
    //    else if (RBSignUp.Checked == true)
    //    {
    //        ++dt.PrimaryKey[]
    //    }
    }
}
