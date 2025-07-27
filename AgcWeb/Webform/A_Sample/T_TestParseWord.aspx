<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="T_TestParseWord.aspx.cs" Inherits="AgcMvc3.Webform.A_Sample.T_TestParseWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnFuncNameParseWord" runat="server" OnClick="btnFuncNameParseWord_Click" Text="测试函数名分词" />
            <asp:Button ID="btnTotalWord" runat="server" OnClick="btnTotalWord_Click" Text="统计分词数" />
            <asp:Button ID="btnParseFeatureId" runat="server" OnClick="btnParseFeatureId_Click" Text="分析功能" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="307px" Width="323px"></asp:ListBox>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
