<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="indexbuy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 115px;
        }
        .style5
        {
            font-size: small;
        }
        .style10
        {
            width: 104px;
        }
        .style12
        {
            font-size: small;
            height: 20px;
        }
        .style13
        {
            width: 104px;
            height: 20px;
        }
        .style14
        {
            height: 20px;
        }
        .style17
        {
            width: 101px;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="indexhead">      
    </div>
    <div id="navy">
     <h1>>>最新商品信息<<</h1>
    </div>
    <div id="index">
        
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" 
            HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" 
            onitemcommand="DataList1_ItemCommand">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <ItemTemplate>
                <table align="center" class="style1">
                    <tr>
                        <td class="style3" rowspan="4">
                            <asp:Image ID="Image1" runat="server" 
                                imageurl='<%# "~/sqlimages/"+Eval("GoodsPhoto") %>' Height="72px" Width="105px" 
                                BorderStyle="Double" />
                        </td>
                        <td align="right" class="style12">
                            名称：</td>
                        <td align="left" class="style13">
                            <asp:Label ID="Label1" runat="server" CssClass="style5" Text='<%#Eval("GoodsName") %>'></asp:Label>
                        </td>
                        <td class="style14">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style17">
                            类别：</td>
                        <td align="left" class="style10">
                            <asp:Label ID="Label2" runat="server" CssClass="style5" Text='<%#Eval("GoodsKind")%>'></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="right" class="style17">
                            单价：</td>
                        <td align="left" class="style10">
                            <asp:Label ID="Label3" runat="server" CssClass="style5" Text='<%#Eval("GoodsPrice") %>'></asp:Label>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td align="center" class="style12" colspan="3">
                            <asp:LinkButton ID="LinkButton1" runat="server" style="font-size: small" CommandArgument='<%#Eval("GoodsID") %>' CommandName="detail">商品详情</asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("GoodsID")%>' CommandName="buy">购买</asp:LinkButton>
                        </td>
                    </tr>
                </table>
                <br>
                <br>
            </ItemTemplate>          
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:DataList>
        
    </div>
    <div id="page">
       
        <asp:Button ID="firstpage" runat="server" Text="首页" onclick="firstpage_Click" />
        <asp:Button ID="uppage" runat="server" Text="上一页" onclick="uppage_Click" />       
        <asp:Label ID="Label7" runat="server" Text="第" Font-Size="Small"></asp:Label>       
        <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="Small" 
            ForeColor="#FF3300"></asp:Label>
        <span class="style5">页</span>/<asp:Label ID="Label5" runat="server" Text="共" Font-Size="Small"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="Small" 
            ForeColor="Red"></asp:Label>
        <span class="style5">页</span><asp:Button ID="nextpage" runat="server" Text="下一页" onclick="nextpage_Click" />
        <asp:Button ID="lastpage" runat="server" Text="末页" onclick="lastpage_Click" />
       
    </div>
    <div id="houtai">
       
        <asp:HyperLink ID="HyperLink1" runat="server" 
            ImageUrl="~/localimages/进入后台按钮.jpg" NavigateUrl="~/Addshopping.aspx">HyperLink</asp:HyperLink>
       
    </div>
     <div id="footer">
        <h1>@copyright 版权所有 翻版必究</h1>
     </div>
    </form>
</body>
</html>
