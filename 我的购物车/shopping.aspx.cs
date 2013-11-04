using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class shopping : System.Web.UI.Page
{
    public static float  allprice;
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            logical l = new logical(str);
            Session["GoodsID"] = int.Parse(Request.QueryString["GoodsID"].ToString());
            string sql = "select * from tb_GoodsInfo where GoodsID=" + int.Parse (Session["GoodsID"].ToString ()) + "";
            DataSet ds = l.indexds(sql);

            if (ds.Tables[0].Rows.Count != 0)
            {
                string GoodsName = ds.Tables[0].Rows[0][1].ToString();
                decimal GoodsPrice = decimal.Parse(ds.Tables[0].Rows[0][4].ToString());
                string sql1 = "select count(*) from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + " and GoodsID=" + int.Parse(Session["GoodsID"].ToString()) + "";
                DataSet ds1 = l.indexds(sql1);
                if (ds1.Tables[0].Rows[0][0].ToString() == "0")
                {
                    string sql2 = "insert into tb_Cart (CartID,GoodsID,GoodsName,GoodsPrice,Num) values (" + int.Parse(Session["UserID"].ToString()) + "," + int.Parse(Session["GoodsID"].ToString()) + ",'" + GoodsName + "','" + GoodsPrice + "'," + "1" + ")";
                    int k = l.usercommand(sql2);                   
                    if (k > 0)
                    {
                        string sql3 = "select *,GoodsPrice*Num as thingPrice from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + "";
                        DataSet ds3 = l.indexds(sql3);                      
                        float price=0;
                        foreach (DataRow rows in ds3.Tables[0].Rows)
                        {
                            price =price +Convert .ToSingle (rows[6]);
                        }
                        allprice = price;
                        this.DataList1.DataSource = ds3;
                        this.DataList1.DataBind();
                        connection.con.Close();
                    }
                }
                else
                {
                    string sql3 = "update tb_Cart set Num=Num+1 where CartID=" + int.Parse(Session["UserID"].ToString()) + " and GoodsID=" + int.Parse(Session["GoodsID"].ToString()) + "";
                    int k = l.usercommand(sql3);                    
                    if (k > 0)
                    {
                        string sql4 = "select *,GoodsPrice*Num as thingprice from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + "";
                        DataSet ds4 = l.indexds(sql4);
                        float price = 0;
                        foreach (DataRow rows in ds4.Tables[0].Rows)
                        {
                            price = price + Convert.ToSingle(rows[6]);
                        }
                        allprice = price;
                        this.DataList1.DataSource = ds4;
                        this.DataList1.DataBind();
                        connection.con.Close();
                    }
                }

            }

        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "update")
        {
            string singenum=((TextBox)e.Item .FindControl ("TextBox1")).Text ;
            logical l = new logical(str);
            string sql="update tb_Cart set Num="+int.Parse (singenum .ToString ())+" where GoodsID="+int.Parse (e.CommandArgument.ToString ())+"";
            int k=l.usercommand(sql);
            if (k > 0)
            {
                string sql4 = "select *,GoodsPrice*Num as thingprice from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + "";
                DataSet ds4 = l.indexds(sql4);
                float price = 0;
                foreach (DataRow rows in ds4.Tables[0].Rows)
                {
                    price = price + Convert.ToSingle(rows[6]);
                }
                allprice = price;
                this.DataList1.DataSource = ds4;
                this.DataList1.DataBind();
                connection.con.Close();
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('更新成功')</script>");
            }
        }
        if (e.CommandName == "delete")
        {
            logical l = new logical(str);
            string sql = "delete from tb_Cart where GoodsID=" + int.Parse(e.CommandArgument.ToString()) + "";
            int k=l.usercommand(sql);
            if (k > 0)
            {
                string sql4 = "select *,GoodsPrice*Num as thingprice from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + "";
                DataSet ds4 = l.indexds(sql4);
                float price = 0;
                foreach (DataRow rows in ds4.Tables[0].Rows)
                {
                    price = price + Convert.ToSingle(rows[6]);
                }
                allprice = price;
                this.DataList1.DataSource = ds4;
                this.DataList1.DataBind();
                connection.con.Close();
                //this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除成功')</script>");
            }
        }
    }

    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        TextBox text = (TextBox)e.Item.FindControl("TextBox1");
        if (text != null)
        {
            text.Attributes["onkeyup"] = "value=value.replace(/[^\\d]/g,'')";
        }
       
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        logical l = new logical(str);
        string sql = "delete from tb_Cart where CartID=" + int.Parse (Session["UserID"].ToString ()) + "";
        int k=l.usercommand(sql);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('您已清空购物车')</script>");
            connection.con.Close();
            Response.Redirect("index.aspx");
        }

    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        logical l = new logical(str);
        string sql = "select * from tb_User where UserID=" + int.Parse(Session["UserID"].ToString()) + "";
        DataSet ds = l.indexds(sql);
        float money = Convert.ToSingle(ds.Tables[0].Rows[0][3].ToString());
        if (allprice < money)
        {
            string sql1 = "delete from tb_Cart where CartID=" + int.Parse(Session["UserID"].ToString()) + "";
            int k = l.usercommand(sql1);
            if (k > 0)
            {
                string sql2 = "update tb_User set Money=Money-" + allprice + " where UserID=" + int.Parse(Session["UserID"].ToString()) + "";
                int k1=l.usercommand(sql2);
                if (k1 > 0)
                {
                    Response.Write("<script>window.open('successshop.aspx','','width=300px;height=500px;status=no;help=no;scrollbars=no');</script>");
                }
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，您的余额不足，请及时充值')</script>");
        }
    }
}