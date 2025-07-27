<%@ Page Language="c#" CodeBehind="wfmPortal.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmPortal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmPortal</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblWelComeMsg" Style="z-index: 108; left: 48px; position: absolute;
            top: 48px" runat="server" Width="432px"  CssClass="h6"></asp:Label>
        <asp:Label ID="lblTitle" Style="z-index: 109; left: 8px; position: absolute; top: 8px"
            runat="server"  CssClass="h5">首页->门户</asp:Label>
    </form>
</body>
</html>
