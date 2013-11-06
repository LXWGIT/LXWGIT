using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Master_MasterPageindex : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Timer1_Tick1(object sender, EventArgs e)
    {
      
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        this.Label2.Text = System.DateTime.Now.ToString();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("manage-jingqu.aspx");
    }
}
