using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class successshop : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        logical l = new logical(str);
        string sql = "select * from tb_User where UserID=" + int.Parse(Session["UserID"].ToString()) + "";
        DataSet ds=l.indexds(sql);
        float money = Convert.ToSingle(ds.Tables[0].Rows[0][3].ToString());
        Response.Write("<font color=black>您已购物成功，余额为："+money +"欢迎下次光临!</font>");
    }
}