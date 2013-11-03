using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration ;
using System.Data;
using System.Data.SqlClient;

public partial class subjectmanage : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.bind();
            this.Calendar1.Visible = false;
            if (Request.QueryString["id"] != null)
            {
                Classsubject c = new Classsubject(str);
                DataSet ds=c.singleselect(int.Parse (Request.QueryString["id"].ToString ()));
                this.TextBox2.Text = ds.Tables["vote"].Rows[0][1].ToString();
                this.TextBox3.Text = ds.Tables["vote"].Rows[0][2].ToString();
                this.TextBox4.Text = ds.Tables["vote"].Rows[0][4].ToString();
                this.Image2.ImageUrl = "~/sqlimages/" + ds.Tables["vote"].Rows[0][3].ToString ();
            }
        }
    }
    public void bind()
    {
        Classsubject su = new Classsubject(str);
        string str1 = "select * from voteMaster";
        DataSet ds = su.singlesubjectmanage(str1);
        this.GridView1.DataSource = ds;
        this.GridView1.DataKeyNames = new string[] { "id" };        
        this.GridView1.DataBind(); 
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex;
        this.bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Classsubject c = new Classsubject(str);
        int k = int.Parse(this.GridView1.DataKeys[e.RowIndex].Value.ToString());
        int k1 = c.singledelete(k);
        if (k1 > 0)
        {
            this.Page.ClientScript.RegisterStartupScript (Page.GetType(), "", "<script>alert('删除成功')</script>");
            this.bind();
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('删除失败')</script>");
            this.bind();
        }
        
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)(e.Row.Cells[6].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除吗？')");
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i <= this.GridView1.Rows.Count - 1; i++)
        {
            CheckBox check = (CheckBox)GridView1.Rows[i].FindControl("Check");
            if (this.CheckBox1.Checked==true )
            {
                check.Checked = true ;
            }
            else
            {
                check.Checked = false;
            }
        
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        this.CheckBox1.Checked = false;
        for (int i = 0; i <= this.GridView1.Rows.Count - 1; i++)
        {
            CheckBox check = (CheckBox)this.GridView1.Rows[i].FindControl("Check");
            check.Checked = false;

        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        for (int i = 0; i < this.GridView1.Rows.Count - 1; i++)
        {
            CheckBox check = (CheckBox)this.GridView1.Rows[i].FindControl("Check");
            if (check.Checked == true)
            {
                Classsubject c = new Classsubject(str);
                int k = int.Parse(this.GridView1.DataKeys[i].Value.ToString());
                int k1 = c.singledelete(k);
                if (k1 > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('批量删除成功')</script>");
                    this.bind();
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('批量删除失败')</script>");
                    this.bind();
                }
            }

        }
        
    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        this.TextBox2.Text = "";
        this.TextBox3.Text = "";
        this.TextBox4.Text = "";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        model  m=new model ();
        m.votetitle=this.TextBox2.Text ;
        m.votesum=int.Parse (this.TextBox3.Text) ;
        m.endtime=DateTime.Parse ( this.TextBox4.Text) ;
        int k = c.singleupdate(int.Parse(Request.QueryString["id"].ToString()), m);
        if (k > 0)
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('修改成功')</script>");
            this.bind();
        }
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        this.TextBox4.Text = this.Calendar1.SelectedDate.ToShortDateString();
        this.Calendar1.Visible = false;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        this.Calendar1.Visible = true;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        model m = new model();
        m.votetitle = this.TextBox1.Text;
        DataSet ds= c.singleselect1(m);
        this.GridView1.DataSource = ds;
        this.GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Clear();
            Response.Buffer = true;
            Response.Charset = "GB2312";
            Response.AppendHeader("Content-Disposition", "attachment;filename=Message.xls");
            Response.ContentEncoding = System.Text.Encoding.UTF7;
            Response.ContentType = "application/ms-excel";//设置输出文件类型为excel文件。 
            System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHtmlTextWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            this.GridView1.RenderControl(oHtmlTextWriter);
            Response.Output.Write(oStringWriter.ToString());
            Response.Flush();
            Response.End();
        }
        catch
        { 
        
        }
    }
}