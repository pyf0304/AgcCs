<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrimaryType.ascx.cs"
    Inherits="AGC.Webform.wucPrimaryType" %>

<table id="tabwucPrimaryTypeName" cellspacing="1" cellpadding="1" width="416" border="0"
    style="width: 416px; height: 244px">
    <tr>
                <td style="text-align:right">
            <asp:Label ID="lblPrimaryTypeId" runat="server"
                ForeColor="Teal">关键字类型号</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrimaryTypeId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
                <td style="text-align:right">
            <asp:Label ID="lblPrimaryTypeName" runat="server"
                ForeColor="Teal">关键字类型名称</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrimaryTypeName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
                <td style="text-align:right">
            <asp:Label ID="lblMemo" runat="server" ForeColor="Teal">说明</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine" Width="308px" Height="184px"></asp:TextBox>
        </td>
    </tr>
</table>
