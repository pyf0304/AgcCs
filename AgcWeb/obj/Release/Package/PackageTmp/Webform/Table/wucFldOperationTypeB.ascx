<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucFldOperationTypeB.ascx.cs" Inherits="AGC.Webform.wucFldOperationTypeB" %>

<table id="tabwucFldOperationType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldOpTypeId" runat="server" CssClass="col-form-label text-right">字段操作类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFldOpTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldOpTypeName" runat="server" CssClass="col-form-label text-right">字段操作类型名称</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFldOpTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
