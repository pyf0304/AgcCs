<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucDictType4GCB.ascx.cs" Inherits="AGC.Webform.wucDictType4GCB" %>

<table id="tabwucDictType4GC" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictTypeId" runat="server" CssClass="col-form-label text-right">字典类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictTypeName" runat="server" CssClass="col-form-label text-right">字典类型名</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
