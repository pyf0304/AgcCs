<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_AGCByWApi.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.T_AGCByWApi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAGCByWApi" runat="server" OnClick="btnAGCByWApi_Click" Text="生成代码ByWApi" />
            <br />
            <asp:TextBox ID="txtCode" runat="server" Height="191px" TextMode="MultiLine" Width="686px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
