<%@ Page Language="c#" CodeBehind="wfmTestWebDraw.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmTestWebDraw" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>wfmTestWebDraw</title>
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <asp:Button ID="Button1" Style="z-index: 101; left: 632px; position: absolute; top: 72px"
            runat="server" Text="Button" Width="160px" Height="32px"></asp:Button>
        <asp:Image ID="Image1" Style="z-index: 102; left: 56px; position: absolute; top: 24px"
            runat="server" Width="600px" Height="250px" ImageUrl="wfmDrawGraph1.aspx"></asp:Image>
        <div id="DIV1" style="display: inline; z-index: 103; left: 200px; width: 560px; position: absolute; top: 144px; height: 368px"
            runat="server">
            Label
        </div>
        <table id="Table1" style="z-index: 104; left: 32px; width: 368px; position: absolute; top: 232px; height: 272px"
            cellspacing="1" cellpadding="1" width="368" border="1"
            runat="server">
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
