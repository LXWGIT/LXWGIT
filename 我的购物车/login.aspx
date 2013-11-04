<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="login">
          <table id="__01" width="1024" height="769" border="0" cellpadding="0" 
              cellspacing="0" align="center">
	<tr>
		<td>
			<img src="localimages/shopping_01.png" width="4" height="401" alt=""></td>
		<td colspan="13">
			<img src="localimages/shopping_02.png" width="1013" height="401" alt=""></td>
		<td rowspan="12">
			<img src="localimages/shopping_03.png" width="7" height="768" alt=""></td>
	</tr>
	<tr>
		<td colspan="2" rowspan="10">
			<img src="localimages/shopping_04.png" width="28" height="360" alt=""></td>
		<td rowspan="9">
			<img src="localimages/shopping_05.png" width="426" height="348" alt=""></td>
		<td rowspan="10">
			<img src="localimages/shopping_06.png" width="27" height="360" alt=""></td>
		<td colspan="8">
			<img src="localimages/shopping_07.png" width="519" height="52" alt=""></td>
		<td rowspan="10">
			<img src="localimages/shopping_08.png" width="13" height="360" alt=""></td>
		<td rowspan="11">
			<img src="localimages/shopping_09.png" width="4" height="367" alt=""></td>
	</tr>
	<tr>
		<td rowspan="8">
			<img src="localimages/shopping_10.png" width="30" height="296" alt=""></td>
		<td colspan="2" align="right">
			<asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        </td>
		<td rowspan="6">
			<img src="localimages/shopping_12.png" width="43" height="233" alt=""></td>
		<td colspan="3">
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" Checked="True" Font-Size="Small" 
                Text="记住用户名" />
        </td>
		<td rowspan="8">
			<img src="localimages/shopping_14.png" width="97" height="296" alt=""></td>
	</tr>
	<tr>
		<td colspan="2">
			<img src="localimages/shopping_15.png" width="131" height="21" alt=""></td>
		<td colspan="3">
			<img src="localimages/shopping_16.png" width="218" height="21" alt=""></td>
	</tr>
	<tr>
		<td colspan="2" align="right">
			<asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
        </td>
		<td colspan="3">
			<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
	</tr>
	<tr>
		<td colspan="2">
			<img src="localimages/shopping_19.png" width="131" height="26" alt=""></td>
		<td colspan="3">
			<img src="localimages/shopping_20.png" width="218" height="26" alt=""></td>
	</tr>
	<tr>
		<td colspan="2" align="right">
			<asp:Label ID="Label3" runat="server" Text="验证码："></asp:Label>
        </td>
		<td colspan="3">
			<asp:TextBox ID="TextBox3" runat="server" Width="103px"></asp:TextBox>                                                 
            <asp:Image ID="Image1" runat="server" onclick="this.src=this.src+'?'" ImageUrl="~/checkcode.aspx" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" style="font-size: small">看不清，换一张</asp:LinkButton>
        </td>
	</tr>
	<tr>
		<td colspan="2">
			<img src="localimages/shopping_23.png" width="131" height="27" alt=""></td>
		<td colspan="3">
			<asp:Button ID="Button1" runat="server" Text="登陆" Width="70px" 
                onclick="Button1_Click"/>
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="重置" Width="70px" 
                onclick="Button2_Click" />
        </td>
	</tr>
	<tr>
		<td rowspan="2">
			<img src="localimages/shopping_25.png" width="57" height="63" alt=""></td>
		<td colspan="2">
			<img src="localimages/shopping_26.png" width="117" height="46" alt=""></td>
		<td rowspan="2">
			<img src="localimages/shopping_27.png" width="30" height="63" alt=""></td>
		<td>
			<img src="localimages/shopping_28.png" width="126" height="46" alt=""></td>
		<td rowspan="2">
			<img src="localimages/shopping_29.png" width="62" height="63" alt=""></td>
	</tr>
	<tr>
		<td colspan="2">
			<img src="localimages/shopping_30.png" width="117" height="17" alt=""></td>
		<td>
			<img src="localimages/shopping_31.png" width="126" height="17" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="localimages/shopping_32.png" width="426" height="12" alt=""></td>
		<td colspan="8">
			<img src="localimages/shopping_33.png" width="519" height="12" alt=""></td>
	</tr>
	<tr>
		<td colspan="13">
			<img src="localimages/shopping_34.png" width="1013" height="7" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="4" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="24" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="426" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="27" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="30" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="57" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="74" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="43" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="30" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="126" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="62" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="97" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="13" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="4" height="1" alt=""></td>
		<td>
			<img src="localimages/&#x5206;&#x9694;&#x7b26;.gif" width="7" height="1" alt=""></td>
	</tr>
</table>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:db_NetShopConnectionString %>" 
        SelectCommand="SELECT * FROM [tb_Cart]"></asp:SqlDataSource>
    </form>
</body>
</html>
