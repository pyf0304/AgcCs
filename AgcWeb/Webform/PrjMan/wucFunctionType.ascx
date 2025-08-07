<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFunctionType.ascx.cs"
    Inherits="AGC.Webform.wucFunctionType" %>
<table id="tabwucFunctionType" cellspacing="1" cellpadding="1" width="368" border="0"
    style="width: 368px; height: 222px">
    <tr>
        <td>
            <asp:Label ID="lblFuncTypeID" runat="server">函数类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFuncTypeID" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFuncTypeNM" runat="server">函数类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFuncTypeName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server">说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="275px" Height="160px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
