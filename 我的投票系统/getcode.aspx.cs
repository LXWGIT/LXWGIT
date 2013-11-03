using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class checkcode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Checkcode c = new Checkcode(Response);
        c.getcheckcode(c.getnum());
    }
}