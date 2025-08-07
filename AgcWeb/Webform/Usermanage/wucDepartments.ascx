<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDepartments.ascx.cs"
    Inherits="AGC.wucDepartments" %>
<table id="tabwucDepartments" cellspacing="1" cellpadding="1" width="352" border="0"
    style="width: 352px; height: 304px">
    <tr>
        <td valign="top">
            <asp:Label ID="lblDepartmentId" runat="server"
                ForeColor="Teal">部门号</asp:Label>
        </td>
        <td valign="top">
            <asp:TextBox ID="txtDepartmentId" runat="server" Width="264px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblDepartmentName" runat="server"
                ForeColor="Teal">部门名称</asp:Label>
        </td>
        <td valign="top">
            <asp:TextBox ID="txtDepartmentName" runat="server" Width="264px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server" ForeColor="Teal">备注</asp:Label>
        </td>
        <td valign="top">
            <asp:TextBox ID="txtMemo" runat="server" Width="271px" Height="221px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
