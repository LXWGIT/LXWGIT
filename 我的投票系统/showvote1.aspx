<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showvote1.aspx.cs" Inherits="showvote1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/showvote1.css" rel="stylesheet" type="text/css" />       
    <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div id="showvote1" >
       
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" 
            BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" 
            Height="165px" HorizontalAlign="Center" Width="847px" 
            onrowdatabound="GridView1_RowDataBound" PageSize="5" 
            onpageindexchanging="GridView1_PageIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="投票主题">
                    <ItemTemplate>
                        <%#DataBinder.Eval (Container.DataItem ,"s_name") %>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                            Height="75px" PageSize="3" Width="840px">
                            <Columns>
                                <asp:BoundField DataField="i_name" HeaderText="投票项目" />
                                <asp:BoundField DataField="i_count" HeaderText="投票票数" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
       
    </div>
 </form>
</body>
</html>
