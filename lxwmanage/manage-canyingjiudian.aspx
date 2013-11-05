<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPageindex.master" AutoEventWireup="true" CodeFile="manage-canyingjiudian.aspx.cs" Inherits="lxwmanage_manage_canyingjiudian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <h1>>>福建旅游局诚信系统</h1>
<ul class="u">
<li>当前位置：餐饮酒店　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
    </li>
</ul>
<ul class="u1">
<li>
酒店名称　<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    　城市　<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    　<asp:Button ID="Button12" runat="server" Text="搜索" />
    </li>
   <li>
    <asp:Button ID="Button7" runat="server" Text="添加酒店" Width="78px" />　　<asp:Button ID="Button8" runat="server" Text="Excel导入" />
</li>
</ul>
<ul class="u2">
<li>
    <asp:DataList ID="DataList1" runat="server">
    </asp:DataList></li>
</ul>
<ul class="u3">
<li>
    <asp:CheckBox ID="CheckBox1" runat="server" Text="本页" Font-Size="Small" />

    <asp:CheckBox ID="CheckBox2" runat="server" Text="全部" Font-Size="Small" />
    　　　<asp:Button ID="Button9" runat="server" Text="删除" width="80px"/>
</li>
</ul>
<ul class="u4">
 <li>
     <asp:Button ID="Button5" runat="server" Text="上一页" />
     &nbsp;<asp:Button ID="Button6"
         runat="server" Text="首页" />
 
    <asp:LinkButton ID="LinkButton1" runat="server">1</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server">2</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton3" runat="server">3</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton4" runat="server">4</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton5" runat="server">5</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton6" runat="server">6</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="LinkButton7" runat="server">7</asp:LinkButton>
    <asp:Button ID="Button10" runat="server" Text="末页" />
    &nbsp;<asp:Button ID="Button11" runat="server" Text="下一页" />
    共<asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#0033CC"></asp:Label>页<asp:Label ID="Label2"
        runat="server" Text="Label" ForeColor="#0033CC"></asp:Label>条记录，每页<asp:Label 
         ID="Label3" runat="server"
            Text="Label" ForeColor="#0033CC"></asp:Label>记录，到 
     <asp:TextBox ID="TextBox3" runat="server" Width="30px"></asp:TextBox>
&nbsp;页&nbsp;
    <asp:Button ID="Button1" runat="server" Text="确定" Width="40px" />
 </li>
</ul>
</asp:Content>

