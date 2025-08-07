<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucProjects.ascx.cs"
    Inherits="AGC.wucProjects" %>
<table id="tabwucProjects" cellspacing="1" cellpadding="1" width="344" border="0"
    style="width: 344px; height: 82px">
    <tr>
        <td valign="top">
            <asp:Label ID="lblPrjId" runat="server"
                ForeColor="Teal">工程号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblPrjName" runat="server"
                ForeColor="Teal">工程名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server" ForeColor="Teal">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="271px" Height="184px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
