<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucDict4GCB.ascx.cs" Inherits="AGC.Webform.wucDict4GCB" %>

<style>
    .myInput{
        width:400px;
    }
</style>
<table id="tabwucDict4GC" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictId" runat="server" CssClass="col-form-label text-right">字典Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictId" runat="server" CssClass="myInput"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictValue" runat="server" CssClass="col-form-label text-right">字典值</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictValue" runat="server" CssClass="myInput"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictTypeId" runat="server" CssClass="col-form-label text-right">字典类型Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDictTypeId" runat="server" CssClass="myInput"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictKey1" runat="server" CssClass="col-form-label text-right">字典关键字1</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictKey1" runat="server" CssClass="myInput"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDictKey2" runat="server" CssClass="col-form-label text-right">字典关键字2</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDictKey2" runat="server" CssClass="myInput"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">说明</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" CssClass="myInput"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
