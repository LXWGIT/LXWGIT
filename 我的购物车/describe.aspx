<%@ Page Language="C#" AutoEventWireup="true" CodeFile="describe.aspx.cs" Inherits="describe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/describe.css" rel="stylesheet" type="text/css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="head">
       <h1>>>详细信息<<</h1>
    </div>
    <div id="item">
        <ul id="ul">
           <li>商品名称：<asp:TextBox ID="GoodsNametxt" runat="server" Enabled="False"></asp:TextBox>
            </li>
           <li>商品类别：<asp:TextBox ID="GoodsTypetxt" runat="server" Enabled="False"></asp:TextBox>
            </li>
           <li>商品价格：<asp:TextBox ID="GoodsPricetxt" runat="server" Enabled="False"></asp:TextBox>
            </li>
        </ul>
        <ul id="ul1">
           <li >商品图像：<asp:Image ID="Image1" runat="server" Height="94px" Width="145px" />
            </li>
           <li>商品介绍：<asp:TextBox ID="GoodsDetailtxt" runat="server" Height="92px" 
                   TextMode="MultiLine" Width="273px" Enabled="False"></asp:TextBox>
            </li>
           
           </ul>
           <ul id="ul2">
           <li>
               <asp:Button ID="Button1" runat="server" Text="返回继续购物" Width="111px" 
                   onclick="Button1_Click" />
            </li>
           <li></li>
           </ul>
       
    </div>
    </form>
</body>
</html>
