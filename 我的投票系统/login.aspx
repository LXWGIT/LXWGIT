<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link href="css/login.css" rel="stylesheet" type="text/css" />
    <title></title>   
</head>
<body>
    <form id="form1" runat="server">
    <div id="login">
      <table id="__01" width="640" height="481" border="0" cellpadding="0" 
            cellspacing="0" align="center">
	<tr>
		<td colspan="10">
			<img src="images/login1_01.png" width="640" height="116" alt=""></td>
	</tr>
	<tr>
		<td colspan="10">
			<img src="images/login1_02.png" width="640" height="67" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="images/login1_03.png" width="428" height="44" alt=""></td>
		<td colspan="6">
			<asp:TextBox ID="usernametext" runat="server" Width="118px"></asp:TextBox>
        </td>
		<td>
			<img src="images/login1_05.png" width="86" height="44" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="images/login1_06.png" width="428" height="38" alt=""></td>
		<td colspan="6">
			<asp:TextBox ID="passwordtext" runat="server" Width="118px" TextMode="Password"></asp:TextBox>
        </td>
		<td>
			<img src="images/login1_08.png" width="86" height="38" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="images/login1_09.png" width="338" height="47" alt=""></td>
		<td colspan="3">
			<img src="images/login1_10.png" width="98" height="47" alt=""></td>
		<td>
			<img src="images/login1_11.png" width="2" height="47" alt=""></td>
		<td colspan="3">
			<asp:TextBox ID="checktext" runat="server" Width="58px"></asp:TextBox>
        </td>
		<td>
			<asp:Image ID="Image1" onclick="this.src=this.scr+'?'" runat="server" ImageUrl="~/getcode.aspx" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server">看不清</asp:LinkButton>
        </td>
		<td>
			<img src="images/login1_14.png" width="86" height="47" alt=""></td>
	</tr>
	<tr>
		<td colspan="2" rowspan="2">
			<img src="images/login1_15.png" width="348" height="52" alt=""></td>
		<td colspan="4" align="center">
			<asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/images/loginbutton_25.gif" onclick="ImageButton1_Click" />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/index.aspx">返回首页</asp:HyperLink>
        </td>
		<td rowspan="2">
			<img src="images/login1_17.png" width="11" height="52" alt=""></td>
		<td colspan="2">
			<img src="images/login1_18.png" width="80" height="44" alt=""></td>
		<td rowspan="2">
			<img src="images/login1_19.png" width="86" height="52" alt=""></td>
	</tr>
	<tr>
		<td colspan="4">
			<img src="images/login1_20.png" width="115" height="8" alt=""></td>
		<td colspan="2">
			<img src="images/login1_21.png" width="80" height="8" alt=""></td>
	</tr>
	<tr>
		<td colspan="10">
			<img src="images/login1_22.png" width="640" height="116" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="338" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="10" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="80" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="8" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="2" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="25" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="11" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="26" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="54" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="86" height="1" alt=""></td>
	</tr>
</table>

    </div>
    </form>
</body>
</html>
