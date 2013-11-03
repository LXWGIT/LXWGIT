using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data ;
using System.Data .SqlClient ;
using System.Configuration ;
public partial class subjectAdd : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["voteConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Calendar1.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Classsubject c = new Classsubject(str);
        model m = new model();
        m.votetitle = this.TextBox1.Text;
        DataSet ds = c.checkvote(m);
        try
        {
            if (this.TextBox1.Text == ds.Tables["vote"].Rows[0][1].ToString())
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，该项目已经存在')</script>");

            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('可以添加此投票项目')</script>");
            }
        }
        catch
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('可以添加此投票项目')</script>");
        }
        connection.con.Close();
       
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        this.Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        this.TextBox2.Text = this.Calendar1.SelectedDate.ToShortDateString();
        this.Calendar1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("subjectmanage.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        if (this.FileUpload1.PostedFile.FileName.ToString() == "")
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请选择要上传的图片')</script>");
        }
        else
        {
            if (this.FileUpload1.HasFile)
            {
                if (this.FileUpload1.PostedFile.ContentLength < 40960)
                {
                    string filepath = this.FileUpload1.PostedFile.FileName;
                    string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1, filepath.Length - (filepath.LastIndexOf("\\")) - 1);
                    string fileex = filepath.Substring(filepath.LastIndexOf(".") + 1);
                    string serverpath=Server.MapPath("~/sqlimages/")+filename;
                    if (fileex.ToLower() == "jpg" || fileex.ToLower() == "gif" || fileex.ToLower() == "bmp")
                    {
                        this.FileUpload1.PostedFile .SaveAs(serverpath);

                    }
                    else
                    {
                        this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('图片格式不正确')</script>");
                    }
                    Classsubject c = new Classsubject(str);
                    model m = new model();
                    m.votetitle = this.TextBox1.Text;
                    m.endtime = DateTime.Parse(this.TextBox2.Text);
                    m.mode = int.Parse(this.DropDownList2.SelectedValue);
                    m.image = filename;
                    int k=c.insertvote(m);
                    this.insertipconfig();
                    if (k > 0)
                    {
                        this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('添加成功')</script>");
                    }
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，图片超过指定大小')</script>");
                }
            }
        }
    }
    public void insertipconfig()
    {
        Classsubject c = new Classsubject(str );
        DataSet ds= c.selectvoteid(this.TextBox1.Text);
        int i =int.Parse ( ds.Tables["vote"].Rows[0][0].ToString());
        model m = new model();
        m.confiid = i;
        m.confiip = int.Parse (this.DropDownList1.SelectedValue);
        m.detailid = i;
        m.detailitem = this.TextBox1.Text;
        c.insertconfig(m);
        c.insertdetails(m);
        connection.con.Close();
    }
}