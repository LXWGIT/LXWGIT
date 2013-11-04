using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class indexbuy : System.Web.UI.Page
{
    
    string str = ConfigurationManager.ConnectionStrings["db_NetShopConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["pageindex"] = "1";
            pagebind();                     
        }
        
           
    }
    public void pagebind()
    {
        PagedDataSource page = new PagedDataSource();
        page.AllowPaging = true;
        page.PageSize = 9;
        int pagecurrent;
        pagecurrent = int.Parse(ViewState["pageindex"].ToString());
        page.CurrentPageIndex = pagecurrent - 1;
        this.Label4.Text = pagecurrent.ToString();                   
        logical l = new logical(str);
        string sql = "select *  from tb_GoodsInfo order by GoodsPrice desc";
        DataSet ds = l.indexds(sql);
        page.DataSource = ds.Tables[0].DefaultView;
        this.DataList1.DataSource = page;
        this.DataList1.DataBind();     
        int pagecount = page.PageCount;
        this.Label6.Text = pagecount.ToString();
        if (page.IsFirstPage)
        {
            this.firstpage.Enabled = false;
            this.uppage.Enabled = false;
        }
        else
        {
            this.firstpage.Enabled = true;
            this.uppage.Enabled = true;
        }
        if (page.IsLastPage)
        {
            this.lastpage.Enabled = false;
            this.nextpage.Enabled = false;
        }
        else
        {
            this.lastpage.Enabled = true;
            this.nextpage.Enabled = true;
        }  
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "detail")
        {
            Response.Redirect("describe.aspx?GoodsID=" + e.CommandArgument.ToString());
        
        }
        if (e.CommandName == "buy")
        {
            if (Session["UserID"] != null)
            {
                Response.Redirect("shopping.aspx?GoodsID=" + e.CommandArgument.ToString());
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('您还未登陆')</script>");
            }
        }
    }
    protected void firstpage_Click(object sender, EventArgs e)
    {
        ViewState["pageindex"] = "1";
        this.pagebind();      

    }
    protected void lastpage_Click(object sender, EventArgs e)
    {
        ViewState["pageindex"] = this.Label6.Text;
        this.pagebind();
     
    }
    protected void uppage_Click(object sender, EventArgs e)
    {
        int pageindex = int.Parse(ViewState["pageindex"].ToString());
        pageindex = pageindex - 1;
        ViewState["pageindex"] = pageindex;
        this.pagebind();
       
    }
    protected void nextpage_Click(object sender, EventArgs e)
    {
        int pageindex = int.Parse(ViewState["pageindex"].ToString());
        pageindex = pageindex + 1;
        ViewState["pageindex"] = pageindex;
        this.pagebind();
     
    }
  
}