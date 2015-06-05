<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SQLInjection.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:TextBox runat="server" ID="txtKeyword"></asp:TextBox></p>
            <p>
                <asp:Button runat="server" ID="btnSearch" Text="搜索" OnClick="btnSearch_Click" /></p>
        </div>
    </form>
</body>
</html>
