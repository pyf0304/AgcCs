<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCheckClick.aspx.cs" Inherits="AGC.Webform.A_Sample.TestCheckClick" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function OnCheckChange() {
            var chkTest= document.getElementById("chkTest");
            var lblTest = document.getElementById("lblTest");
            if (chkTest.checked == true) {
                lblTest.innerText = "checked == true";
            }
            else {
                lblTest.innerText = "checked == false";
            }
            var ddlTest = document.getElementById("ddlTest");
            ddlTest.readOnly = true;
            ddlTest.disabled = false;
            ddlTest.options[1].selected = true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBox ID="chkTest" onclick="OnCheckChange();" runat="server" />
            <asp:Label ID="lblTest" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlTest" runat="server" Enabled="False">
                <asp:ListItem>aa</asp:ListItem>
                <asp:ListItem>bb</asp:ListItem>
                <asp:ListItem>cc</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
