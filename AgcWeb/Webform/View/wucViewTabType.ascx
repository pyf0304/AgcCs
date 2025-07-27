<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewTabType.ascx.cs"
    Inherits="AGC.Webform.wucViewTabType" %>
<table id="tabwucViewTabType" cellspacing="1" cellpadding="1" width="400" border="0"
    style="width: 400px; height: 260px">
    <tr>
        <td>
            <asp:Label ID="lblViewTabTypeId" runat="server">界面表类型码</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewTabTypeId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewTabTypeName" runat="server">界面表类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewTabTypeName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblTabTypeFunction" runat="server">功能说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabTypeFunction" runat="server" Width="291px" TextMode="MultiLine"
                Height="200px"></asp:TextBox>
        </td>
    </tr>
</table>
