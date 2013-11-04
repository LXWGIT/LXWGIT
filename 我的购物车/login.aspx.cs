using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class login : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!Object.Equals(Request.Cookies["User"], null))
            {
                HttpCookie readUserName =Request.Cookies["User"];
                this.TextBox1.Text = readUserName.Value;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
        this.TextBox3.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        if (this.TextBox1.Text != "" && this.TextBox2.Text != "")
        {
            
            Session["UserName"] = this.TextBox1.Text;
            
            //Checkcode c = new Checkcode(Response);
            if (this.TextBox3.Text == Checkcode.num)
            {
                logical l = new logical(str);
                string sql = "select * from tb_User where UserName='" + this.TextBox1.Text + "' and PassWord='" + this.TextBox2.Text + "'";
                DataSet ds= l.indexds(sql);               
                //logical l1 = new logical(str);
                string sql1 = "select * from tb_User where UserName='" + this.TextBox1.Text + "' and PassWord='" + this.TextBox2.Text + "'";
                DataSet ds1 = l.indexds(sql1);                       
                connection.con.Close();
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Session["UserID"] =int.Parse ( ds1.Tables["GoodsInfo"].Rows[0][0].ToString());        
                    createcookie();
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('登陆成功')</script>");
                    Response.Redirect("index.aspx");

                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('输入信息有误')</script>");
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('验证码错误')</script>");
           }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('信息不能为空')</script>");
        }
    }
    private void createcookie()
    {
        HttpCookie cookie = new HttpCookie("User");
        if (this.CheckBox1.Checked)
        {
            cookie.Value = this.TextBox1.Text;
           
        }
        cookie.Expires = DateTime.MaxValue;
        Response.AppendCookie(cookie);
          
    }
   
}