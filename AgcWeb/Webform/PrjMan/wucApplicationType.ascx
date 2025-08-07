<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucApplicationType.ascx.cs"
    Inherits="AGC.Webform.wucApplicationType" %>
<table id="tabwucApplicationType" style="width: 600px" border="0">
    <tr>
        <td>
            <asp:Label ID="lblApplicationTypeId" runat="server">应用程序类型ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtApplicationTypeId" runat="server"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblApplicationTypeName" runat="server">应用程序类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtApplicationTypeName" runat="server"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server">应用程序类型英文名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtApplicationTypeENName" runat="server"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server">说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
