<%@ Page Language="C#" AutoEventWireup="true" CodeFile="morevote.aspx.cs" Inherits="morevote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/morevote.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <div id="head">
      <img alt="" src="images/qtdl_01.jpg"/><img alt="" src="images/qtdl_02.jpg"/>
    </div>
    <div id="neirong1">
     <dl>
        <dt id="a">
          <img alt="" src="images/qtsy_08.jpg"/>
        </dt>
        <dt id="b">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/index.aspx">返回首页</asp:HyperLink>
        </dt>
        <dt id="c">
          
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/voteindex.aspx">在线单选投票区</asp:HyperLink>
        </dt>
        <dt id="d">
          
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/morevote.aspx">在线多选投票区</asp:HyperLink>
        </dt>
        <dt id="e">
          <img alt="" src="images/sy_05.jpg" />
        </dt>
     </dl>
    </div>
    <div id="neirong2">
     <h1><i>明日在线投票</i></h1>
     <dl>
       <dt id="kong">
          
           ||<asp:HyperLink 
               ID="HyperLink4" runat="server" NavigateUrl="~/showvote1.aspx">查看投票结果</asp:HyperLink>
           ||<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/voteindex.aspx">返回首页</asp:HyperLink>
          
       </dt>
       <dt>  
           <asp:GridView ID="GridView1" runat="server" 
               AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
               BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" 
               Height="238px" PageSize="6" Width="777px" 
               onrowdatabound="GridView1_RowDataBound1" DataKeyNames="s_id,s_mode" 
               onpageindexchanging="GridView1_PageIndexChanging">
               <AlternatingRowStyle BackColor="PaleGoldenrod" />
               <Columns>
                   <asp:TemplateField HeaderText="多选投票主题名称">
                       <HeaderTemplate>
                           
                       </HeaderTemplate>
                       <ItemTemplate>
                          <%#DataBinder .Eval (Container.DataItem ,"s_name") %>                          
                           <asp:Panel ID="Panel1" runat="server">
                           </asp:Panel>
                       </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
               <FooterStyle BackColor="Tan" />
               <HeaderStyle BackColor="Tan" Font-Bold="True" />
               <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                   HorizontalAlign="Center" />
               <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
               <SortedAscendingCellStyle BackColor="#FAFAE7" />
               <SortedAscendingHeaderStyle BackColor="#DAC09E" />
               <SortedDescendingCellStyle BackColor="#E1DB9C" />
               <SortedDescendingHeaderStyle BackColor="#C2A47B" />
           </asp:GridView>
       </dt>
       <dt id="chongfu">
           <asp:Label ID="Label1" runat="server" Text="label1"></asp:Label>
       </dt>
       <dt id="chongfu2">
           <asp:Button ID="Button1" runat="server" Text="投票" Width="121px" 
               onclick="Button1_Click1" />
&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="111px" 
               Font-Size="Small">
               <asp:ListItem Value="1">可以</asp:ListItem>
               <asp:ListItem Value="0">不可以</asp:ListItem>
           </asp:DropDownList>
&nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" Text="设置重复投票" onclick="Button2_Click" />
       </dt>
       <dt id="chongfu3">
       </dt>
       <dt id="chongfu4">
       </dt>
     </dl>
    </div>
    <div id="footer">
     <img alt="" src="images/sy_0808.jpg" />
    </div>
    </form>
</body>
</html>
