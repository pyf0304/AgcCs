<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUserRole.ascx.cs"
    Inherits="AGC.wucUserRole" %>
<table id="tabwucUserRole" cellspacing="0" cellpadding="1" width="408" border="0"
    style="width: 408px; height: 266px">
    <tr>
        <td>
            <asp:Label ID="lblRoleId" runat="server" 
                ForeColor="Teal">角色ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRoleId" runat="server" Width="340px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblRole" runat="server"  ForeColor="Teal">角色名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtRole" runat="server" Width="340px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server"  ForeColor="Teal">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="340px" Height="206px" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td>
            
        </td>
        <td>
            
        </td>
    </tr>
</table>
