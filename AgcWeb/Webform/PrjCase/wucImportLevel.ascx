<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucImportLevel.ascx.cs"
    Inherits="AGC.Webform.wucImportLevel" %>
<table id="tabwucImportLevel" cellspacing="1" cellpadding="1" width="240" border="0"
    style="width: 240px; height: 82px">
    <tr>
        <td>
            <asp:Label ID="lblImportLevelId" runat="server" >重要程度ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtImportLevelId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblImportLevel" runat="server" >重要程度</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtImportLevel" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
    </tr>
</table>
