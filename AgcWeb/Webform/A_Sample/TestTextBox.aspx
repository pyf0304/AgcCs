<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestTextBox.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.TestTextBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Color"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="DateTime"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" TextMode="Month"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" TextMode="Range"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" TextMode="Search"></asp:TextBox>
            <asp:TextBox ID="TextBox10" runat="server" TextMode="Time"></asp:TextBox>
            <asp:TextBox ID="TextBox11" runat="server" TextMode="Url"></asp:TextBox>
            <asp:TextBox ID="TextBox12" runat="server" TextMode="Week"></asp:TextBox>
        </div>
    </form>
</body>
</html>
