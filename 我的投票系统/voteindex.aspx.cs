using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class singlevote : System.Web.UI.Page
{
    string str1 = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.gridbind();
        }
    }
    public void gridbind()
    {
        logical L = new logical(str1);
        string str = "select * from voteMaster order by voteSum asc";
        this.GridView1.DataSource = L.voteindex(str);
        this.GridView1.DataKeyNames = new string[] { "id" };
        this.GridView1.DataBind();
        L.con.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        logical L = new logical(str1);
        string str = "select * from voteMaster where id='" + this.GridView1.SelectedValue + "'";
        int i =int.Parse ( L.voteindex(str).Tables["vote"].Rows[0][5].ToString ());
        if (i == 0)
        {
            Response.Redirect("singlevote.aspx?id=" + int.Parse (this.GridView1.SelectedValue.ToString ()));
        }
        else
        {
            Response.Redirect("multivote.aspx?id=" + this.GridView1.SelectedValue);
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.gridbind();
    }
}