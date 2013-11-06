<%@ Page Title="" Language="C#" MasterPageFile="~/master/MasterPageindex.master" AutoEventWireup="true" CodeFile="manage-yonghuquanxian.aspx.cs" Inherits="lxwmanage_manage_yonghuquanxian" %>

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
    <h1>用户权限信息修改</h1>
<ul class="u8">
 <li>
     <asp:GridView ID="GridView1" runat="server" HorizontalAlign="Center">
     </asp:GridView>
    </li>
</ul>
</asp:Content>

