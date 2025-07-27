<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUserGroups.ascx.cs"
    Inherits="AGC.wucUserGroups" %>
<table id="tabwucUserGroups" cellspacing="1" cellpadding="1" width="336" border="0"
    style="width: 336px; height: 107px">
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblGroupId" runat="server" 
                ForeColor="Teal">组号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="PId" runat="server" Width="32px" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtGroupId" runat="server" Width="153px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblGroupName" runat="server" 
                ForeColor="Teal">组名</asp:Label></td>
        <td>
            <asp:TextBox ID="txtGroupName" runat="server" Width="184px" Font-Size="Smaller"></asp:TextBox></td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblPrjId" runat="server" 
                ForeColor="Teal">所属工程</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" AutoPostBack="True" Width="184px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblMemo" runat="server"  ForeColor="Teal">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="268px" Height="144px"></asp:TextBox>
        </td>
    </tr>
</table>
