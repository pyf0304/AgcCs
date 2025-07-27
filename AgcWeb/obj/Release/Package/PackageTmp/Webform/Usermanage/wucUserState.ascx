<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUserState.ascx.cs"
    Inherits="AGC.wucUserState" %>
<table id="tabwucUserState" cellspacing="1" cellpadding="1" width="384" border="0"
    style="width: 384px; height: 232px">
    <tr>
        <td valign="top">
            <asp:Label ID="lblUserStateId" runat="server"
                ForeColor="Teal">用户状态号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserStateId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblUserStateName" runat="server"
                ForeColor="Teal">用户状态名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserStateName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server" ForeColor="Teal">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="293px" Height="202px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
