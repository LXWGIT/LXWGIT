using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data ;
using System.Data .SqlClient ;
using System.Configuration ;

public partial class showvote1 : System.Web.UI.Page
{
       
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindsubject(gettopicsid());
        }
    }
    public int gettopicsid()
    {
        logicalmanage l = new logicalmanage(str);
        string sqlstr="select * from Topics where t_IsCurrent=1";
        DataSet ds=l.gettopicsid(sqlstr);
        int t_id =int.Parse ( ds.Tables["topics"].Rows[0][0].ToString());
        connection.con.Close();
        return t_id;                 
    }
    public void bindsubject(int t_id)
    {
        logicalmanage l1 = new logicalmanage(str);
        string sqlstr1 = "select * from Subjects where s_tid=" + t_id + "";
        DataSet ds1 = l1.gettopicsid(sqlstr1);
        this.GridView1.DataSource = ds1;
        this.GridView1.DataKeyNames = new string[] { "s_id" };
        this.GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        GridView grid = (GridView)e.Row.FindControl("GridView2");
        if (grid != null)
        {
            binditem(grid, int.Parse(this.GridView1.DataKeys[e.Row.RowIndex].Value.ToString()));
        }
    }
    public void binditem(GridView grid, int i_sid)
    {
        logicalmanage l1 = new logicalmanage(str);
        string sqlstr1 = "select * from Items where i_sid=" +i_sid+ "";
        DataSet ds= l1.gettopicsid(sqlstr1);
        grid.DataSource = ds;
        //grid.DataKeyNames = new string[] { "s_id" };
        grid.DataBind();
        connection.con.Close();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        bindsubject(gettopicsid());
    }
}