<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestwucGenViewCode.aspx.cs" Inherits="AGC.Webform.CommonControl.TestwucGenViewCode" %>

<%@ Register Src="wucGenViewCode.ascx" TagName="wucGenViewCode" TagPrefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    

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
    <form id="form1" runat="server">
        <div>
            <uc1:wucGenViewCode ID="wucGenViewCode1" runat="server" />
        </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="AAA" />
            <asp:Button ID="Button1" runat="server" Text="生成CheckBox" OnClick="Button1_Click" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
    </form>
</body>
</html>
