<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="subjectmanage.aspx.cs" Inherits="subjectmanage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div id="head123">
    <h1>明日在线投票</h1>
   </div>
   <div id="index">
     
       <asp:Image ID="Image1" runat="server" ImageUrl="~/images/tubiao.jpg" />
       投票主题/关键字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="导出数据" onclick="Button2_Click" />         
   </div>
   <br>
   <br>
   <div id="gridview">
    <ul>
       <li>
           <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
               AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" 
               BorderStyle="None" BorderWidth="1px" CellPadding="4" Font-Size="Medium" 
               HorizontalAlign="Center" Width="775px" 
               onpageindexchanging="GridView1_PageIndexChanging" 
               onrowdatabound="GridView1_RowDataBound" onrowdeleting="GridView1_RowDeleting">
               <Columns>
                   <asp:TemplateField>
                       <HeaderTemplate>
                           勾选
                       </HeaderTemplate>
                       <ItemTemplate>
                           <asp:CheckBox ID="Check" runat="server" />
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:BoundField DataField="id" HeaderText="投票编号" />
                   <asp:BoundField DataField="voteTitle" HeaderText="投票主题名称" />
                   <asp:BoundField DataField="voteSum" HeaderText="投票总数" />
                   <asp:BoundField DataField="endTime" HeaderText="投票有效期" />
                   <asp:HyperLinkField DataNavigateUrlFields="id" 
                       DataNavigateUrlFormatString="subjectmanage.aspx?id={0}" HeaderText="修改" 
                       Text="修改" />
                   <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
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
       </li>
       <br>
       
       <li>
           <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="Medium" Text="全选" 
               oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="True" />
&nbsp;<asp:Button ID="Button3" runat="server" Text="取消全选" onclick="Button3_Click" />
&nbsp;<asp:Button ID="Button4" runat="server" Text="批量删除" onclick="Button4_Click" 
               Height="21px" />
       </li>
    </ul>
   </div>
   <div id="updateitem">
    
       <table align="center" style="width: 100%">
           <tr>
               <td style="width: 238px; height: 31px" align="right">
                   <asp:Label ID="Label1" runat="server" Text="投票名称："></asp:Label>
               </td>
               <td style="width: 283px; height: 31px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
               </td>
               <td style="width: 56px; height: 31px">
               </td>
               <td rowspan="4" align="center">
                   <asp:Image ID="Image2" runat="server" Height="89px" Width="154px" />
               </td>
           </tr>
           <tr>
               <td style="width: 238px; height: 29px" align="right">
                   <asp:Label ID="Label2" runat="server" Text="投票总数："></asp:Label>
               </td>
               <td style="width: 283px; height: 29px">
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
               </td>
               <td style="width: 56px; height: 29px">
                   <asp:Label ID="Label4" runat="server" Text="图片："></asp:Label>
               </td>
           </tr>
           <tr>
               <td style="width: 238px; height: 34px" align="right">
                   <asp:Label ID="Label3" runat="server" Text="投票有效期："></asp:Label>
               </td>
               <td style="width: 283px; height: 34px">
                  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                   <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">选择日期</asp:LinkButton>
               </td>
               <td style="width: 56px; height: 34px">
                   <asp:Calendar ID="Calendar1" runat="server" BackColor="White" 
                       BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" 
                       Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" 
                       onselectionchanged="Calendar1_SelectionChanged" Width="200px">
                       <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                       <NextPrevStyle VerticalAlign="Bottom" />
                       <OtherMonthDayStyle ForeColor="#808080" />
                       <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                       <SelectorStyle BackColor="#CCCCCC" />
                       <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                       <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                       <WeekendDayStyle BackColor="#FFFFCC" />
                   </asp:Calendar>
               </td>
           </tr>
           <tr>
               <td style="width: 238px">
                   &nbsp;</td>
               <td align="center" style="width: 283px">
                   <asp:Button ID="Button5" runat="server" Text="修改" Width="68px" 
                       onclick="Button5_Click"/>
&nbsp;&nbsp;
                   <asp:Button ID="Button6" runat="server" Text="重置" Width="68px" 
                       onclick="Button6_Click" />
               </td>
               <td style="width: 56px">
                   &nbsp;</td>
           </tr>
       </table>
    
   </div>
   <div id="foot">
    
   </div>
</asp:Content>

