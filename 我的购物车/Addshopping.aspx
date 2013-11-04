<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addshopping.aspx.cs" Inherits="Addshopping" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/css/describe.css" rel="stylesheet" type="text/css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
  <div id="head">
       <h1>>>商品基本信息<<</h1>
    </div>
    <div id="item">
        <ul id="ul">
           <li>商品名称：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </li>
           <li>商品类别：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </li>
           <li>商品价格：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
               <asp:Label ID="Label1" runat="server" Font-Size="Small" ForeColor="Red" 
                   Text="价格格式为：如：10/10.3/10.55"></asp:Label>
            </li>
        </ul>
        <ul id="ul1">
           <li >商品图像：<asp:Image ID="Image1" runat="server" Height="94px" Width="145px" />
               <asp:FileUpload ID="FileUpload1" runat="server" Width="210px" />
&nbsp;
               <asp:Button ID="Button2" runat="server" Text="显示" onclick="Button2_Click" />
            </li>
           <li>商品介绍：<asp:TextBox ID="TextBox4" runat="server" Height="92px" 
                   TextMode="MultiLine" Width="273px"></asp:TextBox>
            </li>
           
           </ul>
        <ul id="ul2">
           <li>
              
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              
               <asp:Button ID="Button3" runat="server" Text="添加" onclick="Button3_Click" />
               <asp:Button ID="Button4" runat="server" Text="返回" onclick="Button4_Click" />
              
            </li>
           <li></li>
        </ul>
       
    </div>
    
    </form>
</body>
</html>
