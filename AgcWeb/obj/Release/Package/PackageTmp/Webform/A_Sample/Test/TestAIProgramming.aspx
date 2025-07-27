<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAIProgramming.aspx.cs" Inherits="AGC.Webform.Test.TestAIProgramming" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Button ID="btnAIProgramming" runat="server" Text="btnAIProgramming" OnClick="btnAIProgramming_Click" />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnAIProgramming2" runat="server" Text="btnAIProgramming元组" OnClick="btnAIProgramming2_Click" />
            <br />
            <asp:Button ID="btnTestOption" runat="server" Text="测试Option" OnClick="btnTestOption_Click" />
        </div>
    </form>
</body>
</html>
