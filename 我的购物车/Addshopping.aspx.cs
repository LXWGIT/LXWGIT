using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Addshopping : System.Web.UI.Page
{
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (this.FileUpload1.HasFile)
        {
            if (this.FileUpload1.PostedFile.ContentLength < 40960)
            {
                string filepath = this.FileUpload1.PostedFile.FileName;
                string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1, filepath.Length - (filepath.LastIndexOf("\\")) - 1);
                string fileEx = filepath.Substring(filepath.LastIndexOf(".") + 1);
                string serverpath = Server.MapPath("~/sqlimages/" + filename);
                if (fileEx.ToLower() == "jpg" || fileEx.ToLower() == "gif" || fileEx.ToLower() == "png" || fileEx.ToLower() == "bmp")
                {
                    this.FileUpload1.SaveAs(serverpath);
                    this.Image1.ImageUrl = "~/sqlimages/" + filename;
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，请选择正确格式的文件')</script>");
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('上传文件应小于40k')</script>");
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请选择您要上传的文件')</script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (this.FileUpload1.HasFile && this.TextBox1.Text != "" && this.TextBox2.Text != "" && this.TextBox3.Text != "" && this.TextBox4.Text != "")
        {
            if (this.FileUpload1.PostedFile.ContentLength < 40690)
            {
                string filepath = this.FileUpload1.PostedFile.FileName;
                string filename = filepath.Substring(filepath.LastIndexOf("\\") + 1, filepath.Length - (filepath.LastIndexOf("\\")) - 1);
                string fileEx = filepath.Substring(filepath.LastIndexOf(".") + 1);
                string serpath = Server.MapPath("~/sqlimages/") + filename;
                if (fileEx.ToLower() == "jpg" || fileEx.ToLower() == "gif" || fileEx.ToLower() == "png" || fileEx.ToLower() == "bmp")
                {
                    this.FileUpload1.SaveAs(serpath);
                    logical l = new logical(str);
                    model m = new model();
                    m.GoodsName = this.TextBox1.Text;
                    m.GoodsKind = this.TextBox2.Text;                                                                    
                    m.GoodsPhoto = "~/sqlimages/"+filename;
                    m.GoodsIntroduce = this.TextBox4.Text;
                    if (l.userinsert(m,this.TextBox3.Text))
                    {
                        this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('添加成功！')</script>");
                    }
                    else
                    {
                        this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请输入正确价格格式！')</script>");
                    }
                    connection.con.Close();
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请选择正确文件格式')</script>");
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('上传文件超过40k')</script>");
            }
        }
        else
        {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('对不起，添加信息不能为空')</script>");
        }
       
    }
}