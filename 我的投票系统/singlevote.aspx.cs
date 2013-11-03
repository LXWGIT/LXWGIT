using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;

public partial class multiview : System.Web.UI.Page
{
    bool flag = false;
    string getip;
    string strcon= ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["id1"] = Request.QueryString["id"];
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("showvote.aspx?id=" + Session["id1"]);
    }
    public string getItem()
    {
        string item="";
        logical L = new logical(strcon);
        string str1 = "select * from voteMaster where id=" + Session["id1"] + "";
        SqlDataReader dr = L.singlevote(str1);
        if (dr.Read())
        {
           item = dr["voteTitle"].ToString();
           connection.con.Close();
        }
        return item;
    }
    protected void Button1_Click(object sender, EventArgs e)
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
                    string sqlstr1 = "insert into voter (id,ip,voteTime) values (" + Session["id1"] + ",'" + getip + "','" + time + "')";
                    checkip c = new checkip(strcon );
                    int k = c.insertvote(sqlstr1);
                    if (k > 0)
                    {
                        logical L = new logical(strcon);
                        string str1 = "update voetDetails set voteNum=voteNum+1 where id=" + Session["id1"] + "";                      
                        if (L.multivote1(str1) == true)
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
    public bool checkip1()
    {
        checkip c = new checkip(strcon);
        flag = false;
        string str = "select checkIP from voteConfig where id=" + Session["id1"] + "";       
        int k = c.checkip1(str);
        if (k == 0)
         {
             flag = true;
         }
         else
         {
             flag = false;
         }
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
        string strsql = "select count(*) from voter where ip='" + getip + "' and id=" + Session["id1"]+"";
        checkip c = new checkip(strcon);
        int k =Convert .ToInt16 ( c.checkip1(strsql));
        if (k == 0)
        {
            flag = true;
        }
        else
        {
            flag = false;
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('禁止重复投票')</script>");
        }
        return flag;
    }
}