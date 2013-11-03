<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="subjectAdd.aspx.cs" Inherits="subjectAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="addhead">
  <h1>明日在线投票</h1>
 </div>
 <br>
 <div id="addtable">
     <table align="center" border="1" style="width: 100%" bgcolor="#e9e7e3">
         <tr>
             <td align="right" style="width: 117px; height: 35px;">
                 投票项目：</td>
             <td style="height: 35px">
                 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                 <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
                     Text="检查投票项目是否存在" />
             </td>
         </tr>
         <tr>
             <td align="right" style="width: 117px; height: 31px;">
                 限制IP：</td>
             <td style="height: 31px">
                 <asp:DropDownList ID="DropDownList1" runat="server">
                     <asp:ListItem Value="0">限制IP</asp:ListItem>
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td align="right" style="width: 117px; height: 33px;">
                 添加投票时间：</td>
             <td style="height: 33px">
                 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">选择日期</asp:LinkButton>
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
             <td align="right" style="width: 117px; height: 34px;">
                 上传图片：</td>
             <td style="height: 34px">
                 <asp:FileUpload ID="FileUpload1" runat="server" Height="17px" />
                <span> 上传图片大小不得超过40kb,且格式为jpg,bmp,gif</span></td>
         </tr>
         <tr>
             <td align="right" style="width: 117px; height: 31px;">
                 请选择模式：</td>
             <td style="height: 31px">
                 <asp:DropDownList ID="DropDownList2" runat="server">
                     <asp:ListItem Value="0">单选模式</asp:ListItem>
                     <asp:ListItem Value="1">多选模式</asp:ListItem>
                 </asp:DropDownList>
             </td>
         </tr>
         <tr>
             <td style="width: 117px; height: 36px;">
                 </td>
             <td style="height: 36px">
                 <asp:Button ID="Button1" runat="server" Text="确定" Width="69px" 
                     onclick="Button1_Click" />
                 &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="取消" Width="69px" 
                     onclick="Button2_Click" />
             </td>
         </tr>
         <tr>
             <td align="right" style="width: 117px; height: 32px;">
                 返回管理主页</td>
             <td style="height: 32px">
                 <span>请注意上传图片的要求</span></td>
         </tr>
     </table>
 </div>
</asp:Content>

