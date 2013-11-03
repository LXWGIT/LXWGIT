<%@ Page Language="C#" AutoEventWireup="true" CodeFile="voteindex.aspx.cs" Inherits="singlevote" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/voteindex.css" rel="stylesheet" type="text/css" />
    <title></title>
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
        </dt>
        <dt id="c">
         
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/voteindex.aspx">在线单选投票</asp:HyperLink>
        </dt>
        <dt id="d">
         
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/morevote.aspx">在线多选投票</asp:HyperLink>
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
          
       </dt>
       <dt id="gridview">          
           <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
               AutoGenerateColumns="False" CellPadding="2" ForeColor="Black" 
               GridLines="None" HorizontalAlign="Center" PageSize="5" Width="761px" 
               BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
               Height="372px" onselectedindexchanged="GridView1_SelectedIndexChanged" 
               onpageindexchanging="GridView1_PageIndexChanging">
               <AlternatingRowStyle BackColor="PaleGoldenrod" />
               <Columns>
                   <asp:CommandField ButtonType="Image" HeaderText="投票操作" 
                       SelectImageUrl="~/images/voteSubmit.gif" ShowSelectButton="True" />
                   <asp:BoundField DataField="voteTitle" HeaderText="投票主题" />
                   <asp:BoundField DataField="voteSum" HeaderText="总票数" />
                   <asp:TemplateField HeaderText="主题图片">
                       <ItemTemplate>
                           <asp:Image ID="Image1" runat="server" imageurl='<%# "sqlimages/"+Eval("image") %>' />
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
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
               ConnectionString="<%$ ConnectionStrings:voteConnectionString %>" 
               SelectCommand="SELECT * FROM [voteMaster]"></asp:SqlDataSource>
       </dt>
     </dl>
    </div>
    <div id="footer">
     <img alt="" src="images/sy_0808.jpg" />
    </div>
   
    </form>
   
</body>
</html>
