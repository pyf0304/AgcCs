<%@ Page Language="c#" CodeBehind="wfmTestQuickLogin.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestQuickLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestQuickLogin</title>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:HyperLink ID="HyperLink1" Style="z-index: 101; left: 120px; position: absolute;
            top: 88px" runat="server" NavigateUrl="../QuickUserLogin.aspx?UserId=pyf&Password=mm012345">¿ìËÙµÇÂ¼²âÊÔ</asp:HyperLink>
    </form>
</body>
</html>
