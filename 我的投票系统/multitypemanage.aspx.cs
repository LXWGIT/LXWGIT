using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class multitypemanage : System.Web.UI.Page
{
    private int sid;
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Button1.Visible = true;
            this.Button2.Visible = false;
            this.bind();
        }
        if (Request.QueryString["t_id"] != null)
        {
            this.Button2.Visible = true;
            this.Button1.Visible = false;
            Classsubject c = new Classsubject(str);
            DataSet ds = c.dstype1(int.Parse(Request.QueryString["t_id"].ToString()));
            this.TextBox1.Text = ds.Tables["type"].Rows[0][1].ToString();
            this.TextBox2.Text = ds.Tables["type"].Rows[0][2].ToString();
            connection.con.Close();
        }

    }
    public void bind()
    {
        Classsubject c = new Classsubject(str);
        DataSet  ds=c.dstype();
        this.GridView1.DataSource = ds;
        this.GridView1.DataKeyNames = new string[] { "t_id" };
        this.GridView1.DataBind();
        connection.con.Close();
    }

    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        Classsubject c = new Classsubject(str);
        model m = new model();
        m.topicsid = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
        int k = c.typedelete(m);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除成功')</script>");
            this.bind();
        }
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)e.Row.Cells[6].Controls[0]).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(int.TryParse(e.CommandArgument.ToString (),out sid )==false ||e.CommandName=="" )
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('没有接受的参数')</script>");
            return;
        }
        if (e.CommandName == "iscurrent")
        {
            Classsubject c = new Classsubject(str);
            model m = new model();
            m.topicsid = sid;
            int k=c.typeupdate(m);
            int k1 = c.typeupdate1(m);
            if (k > 0&&k1>0)
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('设置主题成功')</script>");
                this.bind();
                connection.con.Close();
            }
        }
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.Button1.Visible = true;
        this.Button2.Visible = false;
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        model m = new model();
        m.topicsname = this.TextBox1.Text;
        m.topicscontent = this.TextBox2.Text;
        m.topicsbool = false;
        int k=c.typeinsert(m);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('添加主题成功')</script>");
            this.bind();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bind();
    }
}