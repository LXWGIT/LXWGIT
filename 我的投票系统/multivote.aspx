<%@ Page Language="C#" AutoEventWireup="true" CodeFile="multivote.aspx.cs" Inherits="singevote" %>

<%@ Register src="toupiaohead.ascx" tagname="toupiaohead" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/multivote.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 136px;
        }
        .style3
        {
            width: 136px;
            height: 15px;
        }
        .style4
        {
            height: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="1"> 
       
        <uc1:toupiaohead ID="toupiaohead1" runat="server" />
       
    </div>
    <div id="2">
       
        <table align="center" class="style1">
            <tr>
                <td align="center" class="style3">
                    投票标题：</td>
                <td class="style4" align="left">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style3">
                    投票选项：</td>
                <td class="style4" align="left">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td align="left">
                    <asp:Button ID="Button1" runat="server" Height="21px" Text="确定投票" 
                        onclick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="查看结果" onclick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td align="center" class="style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/voteindex.aspx">返回投票首页</asp:HyperLink>
                </td>
                <td>
&nbsp;
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
