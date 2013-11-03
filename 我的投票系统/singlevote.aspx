<%@ Page Language="C#" AutoEventWireup="true" CodeFile="singlevote.aspx.cs" Inherits="multiview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/singlevote.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 86px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="head">
    <ul>
      <li>
         
          <asp:Image ID="Image1" runat="server" Height="23px" 
           ImageUrl="~/images/tubiao.jpg" Width="35px" />
           多模式投票
      </li>
   </ul>
    </div>
    <div id="head1">

        <table align="center" class="style1">
            <tr>
                <td class="style2">
                    投票标题：</td>
                <td align="left">
                 <%=getItem() %>
                </td>
                
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="我要投票" onclick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="查看结果" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
