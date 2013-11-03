using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data ;
using System.Data .SqlClient ;
using System.Configuration ;
public partial class multisubjectmanage : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Button1.Visible = true;
            this.Button2.Visible = false;
            this.Subjectbind();
            if (this.DropDownList1.Items.Count > 0)
            {
                this.DropDownList1.SelectedIndex = 0;
                this.Subjectbind1();
            }
            if (Request.QueryString["s_id"] != null)
            {
                this.Button1.Visible = false;
                this.Button2.Visible = true;
                selectSubject();
            }
        }
    }
    public void Subjectbind()
    {
        Classsubject c = new Classsubject(str);
        DataSet ds= c.dstype();
        this.DropDownList1.DataSource = ds;
        this.DropDownList1.DataTextField = "t_name";
        this.DropDownList1.DataValueField = "t_id";
        this.DropDownList1.DataBind();
        connection.con.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Subjectbind1();
    }
    public void  Subjectbind1()
    {
        int tid = int.Parse(this.DropDownList1.SelectedValue);
        Classsubject c = new Classsubject(str);
        DataSet ds = c.subjectds(tid);
        this.GridView1.DataSource = ds;
        this.GridView1.DataKeyNames = new string[] { "s_id" };
        this.GridView1.DataBind();
        connection.con.Close();
    }
    private void selectSubject()
    {
        Classsubject c = new Classsubject(str);
        DataSet ds=c.subjectds1(int.Parse(Request.QueryString["s_id"]));
        this.TextBox1.Text = ds.Tables["subject"].Rows[0][1].ToString();      
        connection.con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.Button1.Visible = true;
        this.Button2.Visible = false;
        this.TextBox1.Text = "";
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Classsubject c = new Classsubject(str);
        int k=c.subjectdelete(int.Parse (this.GridView1.DataKeys[e.RowIndex].Value.ToString ()));
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除成功')</script>");
            this.Subjectbind1();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除失败')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        int k = c.subjectupdate(int.Parse(Request.QueryString["s_id"]), this.TextBox1.Text);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('修改成功')</script>");
            Subjectbind1();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('修改失败')</script>");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        Subjectbind1();
    }
}