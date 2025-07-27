<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_JSON1.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.T_JSON1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCombineVarToJSON" runat="server" OnClick="btnCombineVarToJSON_Click" Text="组合变量值进JSON" />
            <asp:Button ID="btnCombineVarToJSON2" runat="server" OnClick="btnCombineVarToJSON2_Click" Text="组合变量值进JSON-2" />
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblMsg1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
