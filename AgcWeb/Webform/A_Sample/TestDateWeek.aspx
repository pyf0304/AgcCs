<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestDateWeek.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.TestDateWeek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="开始日期"></asp:Label>
            <asp:TextBox ID="txtBeginDate" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="当前日期"></asp:Label>
            <asp:TextBox ID="txtCurrDate" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="计算" />
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
