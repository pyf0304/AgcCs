<%@ Page Language="c#" CodeBehind="wfmSetDefaPrj4User.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmSetDefaPrj4User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>frmLogin</title>
    
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <asp:Label ID="lblTitle" Style="z-index: 104; left: 8px; position: absolute; top: 8px"
            runat="server" Width="184px"  CssClass="h5">系统设置->设置默认工程</asp:Label>
        <div style="display: inline; z-index: 107; left: 32px; width: 440px; line-height: normal;
            font-family: Verdana; position: absolute; top: 80px; height: 32px" class="RegionTitleH3">
            <p>
                您目前可以使用的工程有以下几个工程，但您需要设置一个默认工程，该工程是您这次使用本系统的唯一工程。<br/>
                请选择：</p>
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" Style="z-index: 101; left: 24px; position: absolute;
            top: 136px" runat="server" RepeatDirection="Horizontal" RepeatColumns="2">
        </asp:RadioButtonList>
        <asp:Button ID="btnSetDefaPrj" Style="z-index: 102; left: 320px; position: absolute;
            top: 136px" runat="server" Text="设置默认工程"></asp:Button>
        <div style="display: inline; z-index: 105; left: 288px; width: 504px; line-height: normal;
            font-family: Verdana; position: absolute; top: 8px; height: 32px" class="MemoStyle1">
            <p>
                如果当前用户有多个需要生成系统协助的工程，可以设置一个默认工程，以便在其他操作时默认就使用用户定义的默认工程。</p>
        </div>
        <asp:Label ID="lblMsg" Style="z-index: 106; left: 320px; position: absolute; top: 168px"
            runat="server" Height="32px" Width="248px"></asp:Label>
        <asp:Label ID="lblWelComeMsg" Style="z-index: 108; left: 32px; position: absolute;
            top: 48px" runat="server"  Width="432px" CssClass="h6"></asp:Label>
    </form>
</body>
</html>
