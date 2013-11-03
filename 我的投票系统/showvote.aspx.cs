using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class showvote : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            logical L = new logical(str);
            string str1="select * from voetDetails where id="+Request .QueryString ["id"]+"";
            DataSet ds= L.showvote(str1);

            string str2 = "select * from voteMaster where id=" + Request.QueryString["id"] + "";
            DataSet ds1 = L.showvote(str2);
            this.GridView1.DataSource = ds1;
            this.GridView1.DataBind();

            this.GridView2.DataSource = ds;
            this.GridView2.DataBind();
            connection.con.Close();
        }
    }

}