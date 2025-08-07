<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTransWayB.ascx.cs" Inherits="AGC.Webform.wucTransWayB" %>

<table id="tabwucTransWay" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransWayId" runat="server" CssClass="col-form-label text-right">转换方式ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransWayId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransWayName" runat="server" CssClass="col-form-label text-right">转换方式名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransWayName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
