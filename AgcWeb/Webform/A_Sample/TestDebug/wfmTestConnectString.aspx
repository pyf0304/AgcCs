<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmTestConnectString.aspx.cs" Inherits="Webform_TestDebug_wfmTestConnectString" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtConnectstring" runat="server" Width="387px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Style="z-index: 100; left: 59px; position: absolute;
            top: 62px" Text="Label" Width="324px"></asp:Label>
        <asp:Button ID="btnConnect" runat="server" OnClick="btnConnect_Click" Text="连接" /></div>
    </form>
</body>
</html>
