<%@ Page Language="C#" AutoEventWireup="True" CodeBehind="Default.aspx.cs" Inherits="Webform_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<script language=javascript src="../JS/CaseDetails.js"></script>
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div><input id="ss" type="button" value="点播"  onclick="OpenA2AClick()"/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="点击生成" />
        </div>
       </form>
</body>
</html>
