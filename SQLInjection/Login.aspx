<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SQLInjection._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<p>用户名:<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></p>
		<p>密码:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></p>
		<p><asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_OnClick"/></p>
    </div>
    </form>
</body>
</html>
