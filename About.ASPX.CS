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

            ListItem item = new ListItem(classNames);

            ClassList.Items.Add(item);            
        }
    }
 
    protected void ButtonSelect_Click(object sender, EventArgs e)
    {
        DataTable dt = database.RetrieveTablefromCourseTable();

        int index = ClassList.SelectedIndex;

        string[] name = dt.Rows[index].ItemArray.Select(x => x.ToString()).ToArray();

        DataTable classes = new DataTable();

        classes.Columns.Add(name[0]);
        classes.Columns.Add(name[1]);
        classes.Columns.Add(name[2]);
        classes.Columns.Add(name[3]);
        classes.Columns.Add(name[4]);
        classes.Columns.Add(name[5]);
        classes.Columns.Add(name[6]);
        classes.Columns.Add(name[7]);

        GridView1.DataSource = classes;
        GridView1.DataBind();        
    }

    //protected virtual GridViewRow CreateRow(string[] )
    //{

    //}

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        
    }
}
