using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration ;
using System.Data;
using System.Data.SqlClient;
public partial class login : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        HttpCookie num = Request.Cookies["num"];
        if (this.usernametext.Text != "" && this.passwordtext.Text != "")
        {
            if (this.checktext.Text == num .Value )
            {
                checklogin c = new checklogin(str);
                model m = new model();
                m.name  = this.usernametext.Text;
                m.password = this.passwordtext.Text;
                Session["username"] = this.usernametext.Text;
                int k = c.getlogin(m);                                           
                if (k>0 )
                {
                    Response.Redirect("subjectmanage.aspx");
                    
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，您输入的信息有误')</script>");
                   
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请输入正确验证码')</script>");
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('信息不能为空！')</script>");
        }
    }
}