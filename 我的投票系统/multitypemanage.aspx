<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="multitypemanage.aspx.cs" Inherits="multitypemanage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="typehead">
  <h1>明日在线投票</h1>
 </div>
  <br>
 <div id="typegridview">
     <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
         AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
         BorderStyle="None" BorderWidth="1px" CellPadding="4" HorizontalAlign="Center" 
         Width="789px" onrowcommand="GridView1_RowCommand" 
         onrowdatabound="GridView1_RowDataBound" 
         onrowdeleting="GridView1_RowDeleting1" 
         onselectedindexchanging="GridView1_SelectedIndexChanging" 
         onpageindexchanging="GridView1_PageIndexChanging" >
         <Columns>
             <asp:BoundField DataField="t_id" HeaderText="主题类别ID" />
             <asp:BoundField DataField="t_name" HeaderText="主题类别名称" />
             <asp:BoundField DataField="t_content" HeaderText="主题类别内容" />
             <asp:TemplateField HeaderText="当前主题类别">
                 <ItemTemplate>
                     <asp:CheckBox ID="CheckBox1" runat="server" Checked ='<%#DataBinder.Eval(Container.DataItem,"t_IsCurrent") %>' Enabled="false"/>
                 </ItemTemplate>
             </asp:TemplateField>
             <asp:TemplateField HeaderText="设置当前主题类别">
                 <ItemTemplate>
                     <asp:Button id="updatecurrentbtn" runat="server" 
                                    Text='<%#(bool)DataBinder.Eval(Container.DataItem,"t_IsCurrent")==true?"当前主题":"设置为当前主题" %>' 
                                    CommandName="iscurrent" 
                                    CommandArgument='<%#DataBinder.Eval(Container.DataItem,"t_id") %>' 
                                    CausesValidation="False"></asp:Button>

                 </ItemTemplate>
             </asp:TemplateField>
             <asp:HyperLinkField DataNavigateUrlFields="t_id" 
                 DataNavigateUrlFormatString="multitypemanage.aspx?t_id={0}" HeaderText="用户操作" 
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
 <br>
 <div id="typeitem">
     <span>投票主题类别</span><br />
     <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="402px"></asp:TextBox>
 </div>
 <br>
 <div id="typeitem1">
     投票主题内容
  
     <br />
     <asp:TextBox ID="TextBox2" runat="server" Height="123px" TextMode="MultiLine" 
         Width="492px"></asp:TextBox>
 </div>
 <div id="typeitem2" align="left">
     <asp:Button ID="Button1" runat="server" Text="新增主题类别" onclick="Button1_Click" />
     <asp:Button ID="Button2" runat="server" Text="修改主题" />
     <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="取消修改" />
 </div>
</asp:Content>

