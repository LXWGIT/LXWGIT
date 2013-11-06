<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPageindex.master" AutoEventWireup="true" CodeFile="addorupdatejiudian.aspx.cs" Inherits="lxwmanage_addorupdatejiudian" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="indexhead2">
  <div class="indexhead1">
    <ul>
     <li>
       <img alt="" src="../lxwmanage/localimages/愉快.jpg" />
     </li>
     <li>
       <img alt="" src="../lxwmanage/localimages/景区.jpg" />
     </li>
     <li >
       <img alt="" src="../lxwmanage/localimages/旅行社.jpg" />
     </li>
     <li>
       <img alt="" src="../lxwmanage/localimages/酒店.jpg" />
    </li>
   </ul>
  </div>
</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>餐饮酒店信息</h1>
<ul class="u7">
 <li>　　　　　酒店代码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></li>
 <li>　　　　　酒店名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></li>
 <li>　　　　　城　　市：<asp:DropDownList ID="DropDownList1" runat="server">
 </asp:DropDownList>
 </li>
 <li>　　　　　详细地址：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></li>
 <li>　　　　　联&nbsp;&nbsp;系&nbsp;&nbsp;人：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></li>
 <li>　　　　　联系电话：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></li>
 <li class="l">　　　　　酒店介绍：<asp:TextBox ID="TextBox6" runat="server" Height="91px" 
         TextMode="MultiLine" Width="334px"></asp:TextBox></li>
 <li class="l1">　　　　　收费标准：<asp:TextBox ID="TextBox7" runat="server" Enabled="False" 
         Height="95px" TextMode="MultiLine" Width="334px">  标准间：123元/人天  

  单人间：98元/人天  

餐饮标准：商务套餐   1000元/桌</asp:TextBox></li>
 <li>　　　　　星　　级：<asp:DropDownList ID="DropDownList2" runat="server">
 </asp:DropDownList>
 </li>
 <li>
     　　　　　　　　　　　　　　　<asp:Button ID="Button1" runat="server" Text="保存修改" />　　<asp:Button ID="Button2"
         runat="server" Text="保存添加" /></li>
</ul>
</asp:Content>

