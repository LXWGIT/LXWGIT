using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration ;

public partial class morevote : System.Web.UI.Page
{
    
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    public void  getsubject(int s_tid)
    {
        logical L = new logical(str);
        string str1 = "select * from Subjects where s_tid='" + s_tid.ToString () + "'";
        SqlDataReader dr= L.getsubject(str1);
        this.GridView1.DataSource = dr;        
        this.GridView1.DataBind();      
        dr.Close();
    }
   
    public bool getrepeat()
    {
       logical L = new logical(str);
       string str1 = "select * from Profiles";
       SqlDataReader dr= L.Isrepeat(str1);
       dr.Read();    
       bool repeat=bool.Parse( dr["p_IsRepeat"].ToString ());
       Session["isrepeat"] = dr["p_IsRepeat"];
       dr.Close();
       return repeat;          
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
            logical L = new logical(str);
            this.getsubject(L.morevote1());
            this.GridView1.HeaderRow.Cells[0].Text = logical.t_name;
            if (Session["username"] != null)
            {
                this.Label1.Visible = this.Button2.Visible = DropDownList1.Visible = true;
                this.Button1.Visible = false;
                
                if (getrepeat()== false )
                {
                    
                    this.Label1.Text = "不可以重复投票";

                }
                else
                {
                    this.Label1.Text = "可以重复投票";
                }
            }
            else
            {
                this.Label1.Visible = this.Button2.Visible = DropDownList1.Visible = false;
                this.Button1.Visible = true;
            }
        
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        Panel P = (Panel)e.Row.FindControl("Panel1");
        if(P!=null )
        {                       
            if (this.GridView1.DataKeys[e.Row.RowIndex].Values["s_mode"].ToString() == "False")
            {
                RadioButtonList ralist = new RadioButtonList();
                ralist.ID = "ralist1";
                binditem1(ralist, int.Parse(this.GridView1.DataKeys[e.Row.RowIndex].Values["s_id"].ToString()));
                P.Controls.Add(ralist);
                if (ralist.Items.Count < 1)
                {
                    P.Controls.Add(new LiteralControl("<font color='red'>没有投票内容！</font>"));

                }
                
            }
            else
            {
                CheckBoxList checklist = new CheckBoxList();
                checklist.ID = "checklist";                
                binditem (checklist,int.Parse(this.GridView1.DataKeys[e.Row.RowIndex].Values["s_id"].ToString()));
                P.Controls.Add(checklist);
                if (checklist.Items.Count < 1)
                {
                    P.Controls.Add(new LiteralControl("<font color='red'>没有投票内容！</font>"));
                }
                
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        logicalmanage l = new logicalmanage(str);
        int k=l.updaterepeat(this.DropDownList1.SelectedValue);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('重置成功')</script>");
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('重置失败')</script>");
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (Session["isrepeat"] != null && Session["vote"] != null)
        {
            if (Session["isrepeat"].ToString() == "False" && Session["vote"].ToString() == "true")
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('禁止重复投票')</script>");
                return;
            }
        }
        logicalmanage l = new logicalmanage(str);
        logical L = new logical(str);
        foreach (GridViewRow row in this.GridView1.Rows)
        {
            Panel p = (Panel)row.FindControl("Panel1");
            if(p==null) continue ;
            foreach (Control c in p.Controls)
            {
                if (c is CheckBoxList)
                {
                    foreach (ListItem list in ((CheckBoxList)c).Items)
                    {
                        if (list.Selected == true)
                        {
                            int k = l.updatevote(int.Parse(list.Value));
                            if (k > 0)
                            {
                                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('投票成功')</script>");
                                getsubject(L.morevote1());                                
                            }
                        }


                    }
                }
                if(c is RadioButtonList) 
                {
                    foreach (ListItem list in ((RadioButtonList)c).Items)
                    {
                        if (list.Selected == true)
                        {
                            int k = l.updatevote(int.Parse(list.Value));
                            if (k > 0)
                            {
                                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('投票成功')</script>");
                                getsubject(L.morevote1());
                            }
                        }
                    
                    }
                }
            }
        }
        Session["vote"] = "true";
        
    }
    public void binditem(CheckBoxList checklist,int id)
    {
        string str1 = "select * from Items where i_sid=" + id + "";
        logical L = new logical(str);
        SqlDataReader dr = L.getitem(str1);
        checklist.DataSource = dr;
        checklist.DataTextField = "i_name";
        checklist.DataValueField = "i_id";
        checklist.DataBind();
        dr.Close();
    }
    public void binditem1(RadioButtonList ralist, int id)
    {
        string str1 = "select * from Items where i_sid=" + id + "";
        logical L = new logical(str);
        SqlDataReader dr = L.getitem(str1);
        ralist.DataSource = dr;
        ralist.DataTextField = "i_name";
        ralist.DataValueField = "i_id";
        ralist.DataBind();
        dr.Close();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //this.GridView1.PageIndex = e.NewPageIndex;
      
    }
}