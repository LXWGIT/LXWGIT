using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Net;

public partial class singevote : System.Web.UI.Page
{    
    bool flag=false ;
    string getip;
    public int getid;
    string str1 = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
       // request = int.Parse(Request.QueryString["id"].ToString());
        if (!IsPostBack)
        {
            getid =int.Parse ( Request.QueryString["id"]);
            Session["id"] = Request.QueryString["id"];
            logical L = new logical(str1);
            string str = "select * from voteMaster where id='" + getid + "'";
            SqlDataReader dr= L.multivote(str);
            if (dr.Read ())
            {
                this.Label1.Text = dr["voteTitle"].ToString();
                connection.con.Close();
            }
            logical L1 = new logical(str1);
            string str2 = "select * from voetDetails where id='" + getid + "'";
            SqlDataReader dr1 = L1.multivote(str2);
            this.RadioButtonList1.DataTextField = "voteItem";            
            this.RadioButtonList1.DataSource = dr1;
            this.RadioButtonList1.DataBind();
            connection.con.Close();
            
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (this.RadioButtonList1.SelectedValue == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请选择投票内容')</script>");
        }
        else
        {
            flag = false;
            DateTime time = Convert.ToDateTime(DateTime.Now);
            string hostname = Dns.GetHostName();
            IPAddress[] adress = Dns.GetHostAddresses(hostname);
            for (int i = 0; i < adress.Length; i++)
            {
                getip = adress[i].ToString();
            }
            if (checkip1())
            {
                if (isIP())
                {
                    string sqlstr1 = "insert into voter (id,ip,voteTime) values (" + Session ["id"] + ",'" + getip + "','" + time + "')";
                    checkip c = new checkip(str1);
                    int k = c.insertvote(sqlstr1);
                    if (k > 0)
                    {
                        logical L = new logical(str1);
                        string str = "update voetDetails set voteNum=voteNum+1 where voteItem='" + this.RadioButtonList1.SelectedItem.Text + "'";                     
                        if (L.multivote1(str) == true)
                        {
                            connection.con.Close();
                            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('投票成功')</script>");
                        }
                        else
                        {
                            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('投票失败')</script>");
                        }
                    }
                }
            }
        }
    } 
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("showvote.aspx?id=" +Session ["id"] );
      
    }
    public bool checkip1()
    {

        checkip c = new checkip(str1);
        flag = false;
        string str = "select checkIP from voteConfig where id="+Session ["id"] ;
        int k = c.checkip1(str);
        if (k == 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }
        connection.con.Close();
        return flag;
    }
    public bool isIP()
    {
        flag = false;
        string hostname = Dns.GetHostName();
        IPAddress[] adress = Dns.GetHostAddresses(hostname);
        for (int i = 0; i < adress.Length; i++)
        {
            getip = adress[i].ToString();
        }
        string strsql = "select count(*) from voter where ip='" + getip + "' and id=" + Session ["id"]+"";
        checkip c = new checkip(str1);
        int k=Convert .ToInt16 ( c.checkip1(strsql));
        if (k == 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('禁止重复投票')</script>");
        }
        connection.con.Close();
        return flag;
    }
}