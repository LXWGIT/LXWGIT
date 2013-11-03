<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showvote.aspx.cs" Inherits="showvote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="css/showvote.css" rel ="stylesheet" type="text/css" />  
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="showvote" align="center">
       
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            HorizontalAlign="Center" PageSize="1" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="总票数">
                    <ItemTemplate>                       
                    <h1><%#DataBinder .Eval (Container.DataItem ,"voteTitle") %></h1><span>[<%#DataBinder .Eval (Container.DataItem ,"voteSum") %>]</span>
                                                                                    
                        </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
       
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None" 
            HorizontalAlign="Center" PageSize="1">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        该标题对应的票数
                    </HeaderTemplate>
                    <ItemTemplate>
                        <h1><%#DataBinder .Eval (Container.DataItem ,"voteItem") %></h1><span>[<%#DataBinder .Eval (Container.DataItem ,"voteNum") %>]</span>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
       
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/voteindex.aspx">返回投票首页</asp:HyperLink>
        <br />
       
    </div>
    </form>
</body>
</html>
