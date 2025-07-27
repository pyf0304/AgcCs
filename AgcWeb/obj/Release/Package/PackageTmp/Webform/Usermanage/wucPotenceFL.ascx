<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPotenceFL.ascx.cs"
    Inherits="AGC.wucPotenceFL" %>
<table id="tabwucPotenceFL" cellspacing="1" cellpadding="1" width="288" border="0"
    style="width: 288px; height: 80px">
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFLM" runat="server" ForeColor="Teal">分类码</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="PId" runat="server"  ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtFLM" runat="server" Width="88px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFLMC" runat="server" ForeColor="Teal">分类名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFLMC" runat="server" Width="136px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblPrjId" runat="server"
                ForeColor="Teal">所属工程</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="137px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
</table>
