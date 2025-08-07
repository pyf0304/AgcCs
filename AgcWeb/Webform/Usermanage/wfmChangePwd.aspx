<%@ Page Language="c#" CodeBehind="wfmChangePwd.aspx.cs" AutoEventWireup="True" Inherits="AGC.Webform.wfmChangePassWord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>修改密码</title>
    
     <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        
            <asp:TextBox ID="txtOldpwd" Style="z-index: 100; left: 136px; position: absolute; top: 64px"
                runat="server" Width="152px" TextMode="Password" AutoCompleteType="Disabled" AUTOCOMPLETE="off"></asp:TextBox>
            <asp:Label ID="lblNewPassWord" Style="z-index: 112; left: 72px; position: absolute; top: 104px"
                runat="server" >新密码</asp:Label>
            <asp:Label ID="lblConfirmNewPassWord" Style="z-index: 111; left: 48px; position: absolute; top: 144px"
                runat="server" >确认新密码</asp:Label>
            <asp:Label ID="lblTitle"
                runat="server" Font-Names="黑体" Font-Size="Larger"
                ForeColor="#8080FF" CssClass="auto-style1">管理用户权限->修改用户密码</asp:Label>
            <asp:TextBox ID="txtNewpwd" Style="z-index: 101; left: 136px; position: absolute; top: 104px"
                runat="server" Width="152px" TextMode="Password" AutoCompleteType="Disabled" AUTOCOMPLETE="off"></asp:TextBox>
            <asp:TextBox ID="txtNewpwd2" Style="z-index: 102; left: 136px; position: absolute; top: 144px"
                runat="server" Width="152px" TextMode="Password" AutoCompleteType="Disabled" AUTOCOMPLETE="off"></asp:TextBox>
            <asp:Button ID="btnSubmit" Style="z-index: 103; left: 136px; position: absolute; top: 208px"
                runat="server"  Height="32px" Text="提交" OnClick="btnSubmit_Click"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 107; left: 224px; position: absolute; top: 216px" runat="server"></asp:Label>
            <asp:Label ID="lblOldPassWord" Style="z-index: 109; left: 72px; position: absolute; top: 64px" runat="server" >旧密码</asp:Label>
        </font>
    </form>
</body>
</html>
