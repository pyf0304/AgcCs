<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestwucEditRegion4PreviewV2.aspx.cs" Inherits="AGC.Webform.CommonControl.TestwucEditRegion4PreviewV2" %>
<%@ Register src="wucEditRegion4PreviewV2.ascx" tagname="wucEditRegion4Preview" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <uc1:wucEditRegion4Preview ID="wucEditRegion4Preview1" runat="server" />
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
