<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjPotence.ascx.cs"
    Inherits="AGC.wucPrjPotence" %>
<table id="tabwucPrjPotence" cellspacing="1" cellpadding="1" width="360" border="0"
    style="width: 360px; height: 132px">
    <tr>
        <td>
            <asp:Label ID="lblPotenceId" runat="server"
                ForeColor="Teal">权限号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="PId" runat="server" Width="32px" ReadOnly="True"></asp:TextBox>
            <asp:TextBox ID="txtPotenceId" runat="server" Width="112px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server"
                ForeColor="Teal">所属工程</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="152px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFLM" runat="server" ForeColor="Teal">所属分类</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlFLM" runat="server" Width="152px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td style="height: 26px">
            <asp:Label ID="lblPotenceName" runat="server"
                ForeColor="Teal">权限名称</asp:Label>
        </td>
        <td style="height: 26px">
            <asp:TextBox ID="txtPotenceName" runat="server" Width="152px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" ForeColor="Teal">备注</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="292px" Height="160px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
