<%@ Page Language="C#" AutoEventWireup="true" CodeFile="shopping.aspx.cs" Inherits="shopping" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/shopping.css" rel="stylesheet" type="text/css"/>
    
    <title></title>                 
    <style type="text/css">
        .style1
        {
            color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="head">
      <h1>>>购物车<<</h1>
    </div>
    <div id="navy">

        <asp:LinkButton ID="LinkButton5" runat="server" ForeColor="Red" 
            onclick="LinkButton5_Click">继续购物</asp:LinkButton>
&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="Red" 
            onclick="LinkButton4_Click">结账</asp:LinkButton>
&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="Red" 
            onclick="LinkButton3_Click">清空购物车</asp:LinkButton>

    </div>
    <div id="item" align="center">
     
        <asp:DataList ID="DataList1" runat="server" Width="525px" CellPadding="2" 
            ForeColor="Black" HorizontalAlign="Center" Height="191px" onitemcommand="DataList1_ItemCommand" 
            onitemdatabound="DataList1_ItemDataBound" BackColor="LightGoldenrodYellow" 
            BorderColor="Tan" BorderWidth="1px">
            <AlternatingItemStyle BackColor="PaleGoldenrod" />
            <FooterStyle BackColor="Tan" />
            <FooterTemplate>
                <table align="center" >
                    <tr>
                        <td class="style1">
                            合计金额:<%#allprice%>人民币</td>
                        <td align="left">                         
                           </td>
                    </tr>
                </table>
            </FooterTemplate>
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <HeaderTemplate>
              <table align="center">
                    <tr>
                        <td width="70px" class="style1">
                            商品名称</td>
                        <td width="90px" class="style1">
                            单价</td>
                        <td width="50px" class="style1">
                            数量</td>
                        <td width="88px">
                        </td>
                        <td width="60px">
                            &nbsp;</td>
                    </tr>
                </table>
            </HeaderTemplate>
            <ItemTemplate>
                <table align="center">
                    <tr>
                        <td width="90px">
                            <asp:Label ID="Label1" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"GoodsName") %>' ></asp:Label>
                        </td>
                        <td width="65px">
                            <asp:Label ID="Label2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"GoodsPrice") %>'></asp:Label>元
                        </td>
                        <td width="100px">
                            <asp:TextBox ID="TextBox1" runat="server" Height="17px" Width="60px" Text ='<%#DataBinder.Eval(Container.DataItem,"Num") %>'></asp:TextBox>
                        </td>
                        <td width="100px">
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("GoodsID")%>' CommandName="update">更新购物车</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("GoodsID") %>' CommandName="delete">删除</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
            <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        </asp:DataList>
     
    </div>
    <div id="footer">
    
    </div>
    </form>
</body>
</html>
