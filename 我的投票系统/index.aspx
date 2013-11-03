<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 18px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="index">
       <table id="__01" width="1024" height="769" border="0" cellpadding="0" 
            cellspacing="0" align="center">
	<tr>
		<td colspan="7">
			<img src="images/index1_01.png" width="1024" height="185" alt=""></td>
	</tr>
	<tr>
		<td colspan="7">
			<img src="images/index1_02.png" width="1024" height="112" alt=""></td>
	</tr>
	<tr>
		<td colspan="7">
			<img src="images/index1_03.png" width="1024" height="297" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="images/index1_04.png" width="78" height="60" alt=""></td>
		<td bgcolor="c4efa4">
			<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/单选.bmp" 
                onclick="ImageButton1_Click" />
        </td>
		<td colspan="5" >
			<img src="images/index1_06.png" width="739" height="60" alt=""></td>
	</tr>
	<tr>
		<td colspan="3">
			<img src="images/index1_07.png" width="354" height="56" alt=""></td>
		<td bgcolor="c4efa4">
			<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/多选.bmp" 
                onclick="ImageButton2_Click" />
        </td>
		<td colspan="3">
			<img src="images/index1_09.png" width="438" height="56" alt=""></td>
	</tr>
	<tr>
		<td colspan="5" rowspan="2">
			<img src="images/index1_10.png" width="688" height="58" alt=""></td>
		<td bgcolor="c4efa4">
			<asp:ImageButton ID="ImageButton3" runat="server" 
                ImageUrl="~/images/进入后台.bmp" onclick="ImageButton3_Click" />
        </td>
		<td rowspan="2">
			<img src="images/index1_12.png" width="136" height="58" alt=""></td>
	</tr>
	<tr>
		<td class="style1">
			<img src="images/index1_13.png" width="200" height="35" alt=""></td>
	</tr>
	<tr>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="78" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="207" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="69" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="232" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="102" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="200" height="1" alt=""></td>
		<td>
			<img src="images/&#x5206;&#x9694;&#x7b26;.gif" width="136" height="1" alt=""></td>
	</tr>
</table>
    </div>
    </form>
</body>
</html>
