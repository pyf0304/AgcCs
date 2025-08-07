<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucAppPageTypeB.ascx.cs" Inherits="AGC.Webform.wucAppPageTypeB" %>

<table id="tabwucAppPageType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAppPageTypeId" runat="server" CssClass="col-form-label text-right">App页面类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtAppPageTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAppPageTypeName" runat="server" CssClass="col-form-label text-right">App页面类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtAppPageTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblAppPageTypeENName" runat="server" CssClass="col-form-label text-right">App页面类型英文名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtAppPageTypeENName" runat="server" class="form-control-sm"></asp:TextBox>
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
