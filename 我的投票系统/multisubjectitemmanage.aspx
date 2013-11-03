<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="multisubjectitemmanage.aspx.cs" Inherits="multisubjectitermanage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="itemhead">
   <h1>明日在线投票</h1>
  </div>
  <div id="item1">
   <span>1.请选择一个主题类别：</span>
      <br />
      <br />
      <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="120px" 
          AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
      </asp:DropDownList>
  </div>
  <br>
  <div id="item2">
   <span>2.请选择一个投票主题：</span>
      <br />
      <br />
      <asp:DropDownList ID="DropDownList2" runat="server" Height="20px" Width="119px" 
          AutoPostBack="True" 
          onselectedindexchanged="DropDownList2_SelectedIndexChanged">
      </asp:DropDownList>
  </div>
  <br>
  <div id="item5">
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
          BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
          CellPadding="4" Height="136px" HorizontalAlign="Center" Width="793px" 
          onrowdatabound="GridView1_RowDataBound" 
          onrowdeleting="GridView1_RowDeleting" AllowPaging="True" 
          onpageindexchanging="GridView1_PageIndexChanging" PageSize="6">
          <Columns>
              <asp:BoundField DataField="i_name" HeaderText="投票内容" />
              <asp:BoundField DataField="i_count" HeaderText="投票票数" />
              <asp:HyperLinkField DataNavigateUrlFields="i_id" 
                  DataNavigateUrlFormatString="multisubjectitemmanage.aspx?i_id={0}" HeaderText="用户操作" 
                  Text="更新" />
              <asp:CommandField HeaderText="用户操作" ShowDeleteButton="True" />
          </Columns>
          <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
          <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
          <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
          <RowStyle BackColor="White" ForeColor="#330099" />
          <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
          <SortedAscendingCellStyle BackColor="#FEFCEB" />
          <SortedAscendingHeaderStyle BackColor="#AF0101" />
          <SortedDescendingCellStyle BackColor="#F6F0C0" />
          <SortedDescendingHeaderStyle BackColor="#7E0000" />
      </asp:GridView>
  </div>
  <div id="item3">
   <span>新增投票主题内容：</span>
      <br />
      <asp:TextBox ID="TextBox1" runat="server" Height="73px" TextMode="MultiLine" 
          Width="436px"></asp:TextBox>
      <br />
  </div>   
  <div id="item4" align="left">
   
      <asp:Button ID="Button1" runat="server" Text="增加投票" onclick="Button1_Click" />
   
      <asp:Button ID="Button2" runat="server" Text="修改投票" onclick="Button2_Click" />
      <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="取消修改" />
   
  </div>
</asp:Content>

