using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class multisubjectitermanage : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
   // private int[] s_id= new int[1];
    //int i_id;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            Topicsbind();
            this.Button1.Visible = true;
            this.Button2.Visible = false;
            if (this.DropDownList1.Items.Count > 0)
            {
                this.DropDownList1.SelectedIndex = 0;
                Subjectbind();
            }
            if (Request.QueryString["i_id"] != null)
            {
                this.Button1.Visible = false;
                this.Button2.Visible = true;
                selectitem();
                gridviewbind1();
                Session["id"] = Request.QueryString["i_id"];
            }
        }
       
        
        
    }
    private void Topicsbind()
    {
        Classsubject c = new Classsubject(str);
        DataSet ds= c.dstype();
        this.DropDownList1 .DataSource =ds;
        this.DropDownList1 .DataTextField ="t_name";
        this.DropDownList1.DataValueField = "t_id";
        this.DropDownList1.DataBind();
        connection.con.Close();
    }
    private void Subjectbind()
    {
        Classsubject c = new Classsubject(str);
        DataSet ds = c.subjectds(int.Parse (this.DropDownList1.SelectedValue));
        this.DropDownList2.DataSource = ds;
        this.DropDownList2.DataTextField = "s_name";
        this.DropDownList2.DataValueField = "s_id";
        this.DropDownList2.DataBind();
        connection.con.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Subjectbind();
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.gridviewbind();
        Session["s_id"] = int.Parse(this.DropDownList2.SelectedValue);
    }
    private void selectitem()
    {       
        Classsubject c = new Classsubject(str);       
        DataSet  ds=c.itemds1(int.Parse(Request.QueryString["i_id"]));
        this.TextBox1.Text = ds.Tables["item"].Rows[0][1].ToString();      
        connection.con.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.Button1.Visible = true;
        this.Button2.Visible = false;
        this.TextBox1.Text = "";
    }
    private void gridviewbind()
    {               
        Classsubject c = new Classsubject(str);
        DataSet ds = c.itemds(int.Parse(this.DropDownList2.SelectedValue));
        this.GridView1.DataSource = ds;
        this.GridView1.DataKeyNames = new string[] { "i_id" };
        this.GridView1.DataBind();
        connection.con.Close();
    }
    private void gridviewbind1()
    {
        Classsubject c = new Classsubject(str);
        DataSet ds = c.itemds(int.Parse (Session ["s_id"].ToString ()));
        this.GridView1.DataSource = ds;
        this.GridView1.DataKeyNames = new string[] { "i_id" };
        this.GridView1.DataBind();
        connection.con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        //this.Button2.Text = Request.QueryString["i_id"].ToString();
        Classsubject c = new Classsubject(str);
        int k = c.itemupdate(this.TextBox1.Text, int.Parse(Session ["id"].ToString ()));
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('修改成功')</script>");
            this.gridviewbind1();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('修改失败')</script>");
        }
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Classsubject c = new Classsubject(str);
        int k=c.itemdelete(int.Parse (this.GridView1.DataKeys[e.RowIndex ].Value.ToString ()));
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除成功')</script>");
            this.gridviewbind1();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除失败')</script>");
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)e.Row.Cells[3].Controls[0]).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        int k=c.iteminsert(this.TextBox1.Text , 0, int.Parse (Session["s_id"].ToString ()));
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('添加成功')</script>");
            this.gridviewbind1();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('添加失败')</script>");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.gridviewbind();
    }
}