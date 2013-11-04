using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data .SqlClient ;
using System.Configuration ;
public partial class describe : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        logical l = new logical(str);
        string sql="select * from tb_GoodsInfo where GoodsID="+Request .QueryString ["GoodsID"]+"";
        DataSet ds=l.indexds(sql);
        this.GoodsNametxt.Text = ds.Tables["GoodsInfo"].Rows[0][1].ToString();
        this.GoodsTypetxt.Text = ds.Tables["GoodsInfo"].Rows[0][2].ToString();
        this.GoodsPricetxt.Text = ds.Tables["GoodsInfo"].Rows[0][4].ToString();
        this.GoodsDetailtxt.Text = ds.Tables["GoodsInfo"].Rows[0][4].ToString();
        this.Image1.ImageUrl = "~/sqlimages/" + ds.Tables["GoodsInfo"].Rows[0][3].ToString();
        connection.con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
}