<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="wfmEncrypt.aspx.cs" Inherits="Webform_wfmEncrypt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnEncrypt" runat="server" OnClick="btnEncrypt_Click" Text="加密web_Config"
            Width="130px" />
        <asp:Button ID="btnDecrypt" runat="server" Text="解密web_Config" Width="130px" OnClick="btnDecrypt_Click" />&nbsp;
        <asp:Button ID="btnGetConnectString4Encrypt" runat="server" Text="获取加密连接串" Width="130px" OnClick="btnGetConnectString4Encrypt_Click" />
        <asp:TextBox ID="TextBox1" runat="server" Height="409px" TextMode="MultiLine" Width="611px"></asp:TextBox></div>
    </form>
</body>
</html>
