<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="multisubjectmanage.aspx.cs" Inherits="multisubjectmanage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="subjecthead">
  <h1>明日在线投票</h1>
 </div>
 <div id="subjectkong">
  
 </div>
 <br>
 <div id="subjectdro">
  <span>请选择投票类别：<br />
     <br />
     </span>
     <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="113px" 
         AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
     </asp:DropDownList>
     <br>
 </div>
 <br>
 <div id="subjectgridview">
  
     <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
         AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
         BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="131px" 
         HorizontalAlign="Center" Width="783px" 
         onrowdatabound="GridView1_RowDataBound" 
         onrowdeleting="GridView1_RowDeleting" 
         onpageindexchanging="GridView1_PageIndexChanging">
         <Columns>
             <asp:BoundField DataField="s_id" HeaderText="投票主题" />
             <asp:BoundField DataField="s_name" HeaderText="投票主题名称" />
             <asp:TemplateField HeaderText="投票主题模式">
                 <ItemTemplate>
                    <asp:RadioButton runat="server" ID="radiobutton" Checked='<%#DataBinder.Eval(Container.DataItem,"s_mode") %>' Text='<%#(bool)DataBinder.Eval(Container.DataItem,"s_mode")==true?"多选":"单选" %>' Enabled="false"/>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:HyperLinkField DataNavigateUrlFields="s_id" 
                 DataNavigateUrlFormatString="multisubjectmanage.aspx?s_id={0}" 
                 HeaderText="用户操作" Text="更新" />
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
  <br>
 </div>
 <div id="subjectitem">
     <span>投票主题</span>
     <br />
     <br />
     <asp:TextBox ID="TextBox1" runat="server" Height="72px" TextMode="MultiLine" 
         Width="495px"></asp:TextBox>
 </div>
 <br>
 <div id="subjectfoot ">
  
     <asp:Button ID="Button1" runat="server" Text="新增投票主题" />
  
     <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="修改投票主题" />
     <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="取消修改" />
  
 </div>
</asp:Content>

