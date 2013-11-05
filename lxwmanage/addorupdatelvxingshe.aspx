<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPageindex.master" AutoEventWireup="true" CodeFile="addorupdatelvxingshe.aspx.cs" Inherits="lxwmanage_addorupdatelvxingshe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>>>旅行社信息</h1>
  <ul class="u6">
  <li>　　　　旅行社代码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>　<asp:TextBox ID="TextBox2"
      runat="server" Width="38px"></asp:TextBox>　网点</li>
  <li>　　　　　企业名称：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>　　简称：<asp:TextBox ID="TextBox4"
      runat="server"></asp:TextBox></li>
  <li>　　　　　所属企业：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></li>
  <li>　　　　　企业形式：<asp:DropDownList ID="DropDownList1" runat="server">
  </asp:DropDownList>
  </li>
  <li>　　　　　企业类别：<asp:DropDownList ID="DropDownList2" runat="server">
  </asp:DropDownList>
  </li>
  <li>　　　　　联&nbsp;&nbsp;系&nbsp;&nbsp;人：　<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></li>
  <li>　　　　　联系电话：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></li>
  <li>　　　　　城　　市：<asp:DropDownList ID="DropDownList3" runat="server">
  </asp:DropDownList>
  </li>
  <li>　　　　　详细地址：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></li>
  <li class="l">　　　　　经营范围：<asp:TextBox ID="TextBox9" runat="server" Height="91px" 
          TextMode="MultiLine" Width="323px"></asp:TextBox></li>
  <li>
      　　　　　　　　　　　　　　<asp:Button ID="Button1" runat="server" Text="保存修改" />
      　　　<asp:Button ID="Button2" runat="server" Text="保存添加" />
      </li>
  </ul>
</asp:Content>

