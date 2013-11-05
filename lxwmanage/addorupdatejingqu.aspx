<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPageindex.master" AutoEventWireup="true" CodeFile="addorupdatejingqu.aspx.cs" Inherits="lxwmanage_addorupdatejingqu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>>>景区信息</h1>
<ul class="u5">
 <li>　　　　　景区代码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></li>
 <li>　　　　　景区名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></li>
 <li>　　　　　城　　市：<asp:DropDownList ID="DropDownList1" runat="server">
 </asp:DropDownList>
 </li>
 <li>　　　　　详细地址：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></li>
 <li>　　　　　联&nbsp;&nbsp;系&nbsp;&nbsp;人：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></li>
 <li>　　　　　联系电话：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></li>
 <li class="l">　　　　　景区介绍：<asp:TextBox ID="TextBox6" runat="server" Height="90px" 
         TextMode="MultiLine" Width="298px"></asp:TextBox></li>
 <li class="l1">　　　　　收费标准：<asp:TextBox ID="TextBox7" runat="server" Height="73px" 
         TextMode="MultiLine" Enabled="False" Width="298px">成人票：23元/人　
　
儿童票：10元/人</asp:TextBox></li>
 <li>
     　　　　　　　　　　　　<asp:Button ID="Button1" runat="server" Text="保存修改" />
    　　　<asp:Button ID="Button2" runat="server" Text="保存添加" />
    </li>
</ul>
</asp:Content>

